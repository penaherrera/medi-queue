using medi_queue.database;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medi_queue.SecretariaViews
{
    public partial class RegistroPacientesForm : Form
    {
        private int? pacienteIdSeleccionado = null;

        public RegistroPacientesForm()
        {
            InitializeComponent();
            panel2.Visible = false;
            CargarPacientes();
            CargarColaEspera();
        }

        private void CargarPacientes()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    var dt = new DataTable();
                    using (var cmd = new SqlCommand(
                       @"SELECT 
                    IDPatient,
                    Name AS Paciente,
                    BirthDate AS FechaNacimiento,
                    CASE Gender WHEN 'M' THEN 'Hombre' WHEN 'F' THEN 'Mujer' ELSE 'Otro' END AS Género,
                    PhoneNumber AS Teléfono
                FROM Patients
                ORDER BY Name", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvPacientes.DataSource = dt;
                    dgvPacientes.Columns["IDPatient"].Visible = false; // Oculta la columna en la vista si no quieres mostrarla
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            LimpiarFormulario();
            pacienteIdSeleccionado = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pacienteIdSeleccionado = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                panel2.Visible = true;
                var row = dgvPacientes.SelectedRows[0];
                pacienteIdSeleccionado = Convert.ToInt32(row.Cells["IDPatient"].Value);
                // Cargar datos en los campos del formulario
                string[] nombreCompleto = row.Cells["Paciente"].Value.ToString().Split(' ');
                txtNombre.Text = nombreCompleto.Length > 0 ? nombreCompleto[0] : "";
                txtApellido.Text = nombreCompleto.Length > 1 ? string.Join(" ", nombreCompleto.Skip(1)) : "";
                dtpFechaNacimiento.Value = row.Cells["FechaNacimiento"].Value is DateTime dt ? dt : DateTime.Now;
                cmbGenero.SelectedItem = row.Cells["Género"].Value.ToString();
                txtTelefono.Text = row.Cells["Teléfono"].Value.ToString();
                // txtDui.Text: deberías cargarlo con una consulta adicional si no está en el DataGridView
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var row = dgvPacientes.SelectedRows[0];
                int idPaciente = Convert.ToInt32(row.Cells["IDPatient"].Value);

                // Verificar si el paciente tiene citas activas
                try
                {
                    using (var conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();
                        using (var cmd = new SqlCommand(
                            @"SELECT COUNT(*) FROM Appointments 
                      WHERE IDPatient = @IDPatient AND Status IN ('Pending', 'Confirmed')", conn))
                        {
                            cmd.Parameters.AddWithValue("@IDPatient", idPaciente);
                            int citasActivas = (int)cmd.ExecuteScalar();

                            if (citasActivas > 0)
                            {
                                MessageBox.Show("No se puede eliminar el paciente porque tiene una cita activa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        var result = MessageBox.Show("¿Desea eliminar el paciente seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            using (var cmd = new SqlCommand("DELETE FROM Patients WHERE IDPatient = @IDPatient", conn))
                            {
                                cmd.Parameters.AddWithValue("@IDPatient", idPaciente);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Paciente eliminado correctamente.");
                            CargarColaEspera();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar paciente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para eliminar.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                cmbGenero.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }

            string nombre = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            string genero = cmbGenero.SelectedItem.ToString().StartsWith("F") ? "F" : "M";
            string telefono = txtTelefono.Text.Trim();
            string dui = txtDui.Text.Trim();

            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    if (pacienteIdSeleccionado.HasValue)
                    {
                        // UPDATE
                        using (var cmd = new SqlCommand(
                            @"UPDATE Patients SET Name=@Name, BirthDate=@BirthDate, Gender=@Gender, PhoneNumber=@PhoneNumber, Dui=@Dui
                      WHERE IDPatient=@IDPatient", conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", nombre);
                            cmd.Parameters.AddWithValue("@BirthDate", fechaNacimiento);
                            cmd.Parameters.AddWithValue("@Gender", genero);
                            cmd.Parameters.AddWithValue("@PhoneNumber", telefono);
                            cmd.Parameters.AddWithValue("@Dui", dui);
                            cmd.Parameters.AddWithValue("@IDPatient", pacienteIdSeleccionado.Value);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Paciente modificado correctamente.");
                    }
                    else
                    {
                        // INSERT
                        using (var cmd = new SqlCommand(
                            @"INSERT INTO Patients (Name, BirthDate, Gender, PhoneNumber, Dui)
                      VALUES (@Name, @BirthDate, @Gender, @PhoneNumber, @Dui)", conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", nombre);
                            cmd.Parameters.AddWithValue("@BirthDate", fechaNacimiento);
                            cmd.Parameters.AddWithValue("@Gender", genero);
                            cmd.Parameters.AddWithValue("@PhoneNumber", telefono);
                            cmd.Parameters.AddWithValue("@Dui", dui);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Paciente registrado correctamente.");
                    }
                }
                panel2.Visible = false;
                pacienteIdSeleccionado = null;
                CargarColaEspera();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar paciente: " + ex.Message);
            }
        }

        private void LimpiarFormulario()
        {
            // Limpiar campos del formulario
        }

        private void btnCrearCitaPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var row = dgvPacientes.SelectedRows[0];
                int idPaciente = Convert.ToInt32(row.Cells["IDPatient"].Value);
                string nombre = row.Cells["Paciente"].Value.ToString();
                DateTime? fechaNacimiento = row.Cells["FechaNacimiento"].Value as DateTime?;
                string genero = row.Cells["Género"].Value.ToString();
                string telefono = row.Cells["Teléfono"].Value.ToString();

                var form = new CrearCitaPacienteForm(idPaciente, nombre, fechaNacimiento, genero, telefono);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Refrescar la lista de pacientes o citas si es necesario
                }
            }
            else
            {
                MessageBox.Show("Seleccione un paciente para crear la cita.");
            }
        }

        private void CargarColaEspera()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    var dt = new DataTable();
                    using (var cmd = new SqlCommand(
                   @"SELECT 
                    IDPatient,
                    Name AS Paciente,
                    BirthDate AS FechaNacimiento,
                    CASE Gender WHEN 'M' THEN 'Hombre' WHEN 'F' THEN 'Mujer' ELSE 'Otro' END AS Género,
                    PhoneNumber AS Teléfono
                FROM Patients
                ORDER BY Name", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvPacientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }
    }
}
