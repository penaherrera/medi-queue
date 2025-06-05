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
    public partial class ListaPacientesForm : Form
    {
        public ListaPacientesForm()
        {
            InitializeComponent();
            CargarPacientesConCita();
            CargarColaEspera();
        }

        private void CargarPacientesConCita()
        {
            // Lógica para cargar pacientes con cita en dgvPacientesConCita
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientesConCita.SelectedRows.Count > 0)
            {
                var row = dgvPacientesConCita.SelectedRows[0];
                int idCita = Convert.ToInt32(row.Cells["IDAppointment"].Value);
                string nombrePaciente = row.Cells["Paciente"].Value.ToString();

                var modificarForm = new ModificarCitaForm(idCita, nombrePaciente);
                if (modificarForm.ShowDialog() == DialogResult.OK)
                {
                    CargarColaEspera();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para modificar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientesConCita.SelectedRows.Count > 0)
            {
                var row = dgvPacientesConCita.SelectedRows[0];
                int idCita = Convert.ToInt32(row.Cells["IDAppointment"].Value);

                var result = MessageBox.Show("¿Desea eliminar la cita seleccionada?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();
                            using (var cmd = new SqlCommand("DELETE FROM Appointments WHERE IDAppointment = @IDAppointment", conn))
                            {
                                cmd.Parameters.AddWithValue("@IDAppointment", idCita);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Cita eliminada correctamente.");
                        CargarColaEspera();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la cita: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para eliminar.");
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
                    a.IDAppointment,
                    p.Name AS Paciente,
                    p.BirthDate AS FechaNacimiento,
                    CASE p.Gender WHEN 'M' THEN 'Hombre' WHEN 'F' THEN 'Mujer' ELSE 'Otro' END AS Género,
                    p.PhoneNumber AS Teléfono,
                    a.DateTime AS FechaCita,
                    a.Status AS Estado
                        FROM Appointments a
                        INNER JOIN Patients p ON a.IDPatient = p.IDPatient
                        WHERE a.Status = 'Confirmed'
                    ORDER BY a.DateTime", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvPacientesConCita.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }
    }
}
