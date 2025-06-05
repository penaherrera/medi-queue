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
    public partial class CrearCitaPacienteForm : Form
    {
        private int idPaciente;
        public CrearCitaPacienteForm(int idPaciente, string nombre, DateTime? fechaNacimiento, string genero, string telefono)
        {
            InitializeComponent();
            this.idPaciente = idPaciente;
            txtNombre.Text = nombre;
            txtFechaNacimiento.Text = fechaNacimiento?.ToString("yyyy-MM-dd") ?? "";
            txtGenero.Text = genero;
            txtTelefono.Text = telefono;
            CargarDoctores();
        }

        private void CargarDoctores()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT IDDoctor, Name FROM Doctors", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            var doctores = new DataTable();
                            doctores.Load(reader);
                            cmbDoctores.DataSource = doctores;
                            cmbDoctores.DisplayMember = "Name";
                            cmbDoctores.ValueMember = "IDDoctor";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los doctores: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbDoctores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un doctor.");
                return;
            }

            try
            {
                int idCita = 0;
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO Appointments (IDPatient, IDDoctor, DateTime, Status, Symptoms)
                  VALUES (@IDPatient, @IDDoctor, @DateTime, 'Pending', @Symptoms);
                  SELECT SCOPE_IDENTITY();", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDPatient", idPaciente);
                        cmd.Parameters.AddWithValue("@IDDoctor", cmbDoctores.SelectedValue);
                        cmd.Parameters.AddWithValue("@DateTime", dtpFechaCita.Value);
                        cmd.Parameters.AddWithValue("@Symptoms", txtSintomas.Text);
                        idCita = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                MessageBox.Show("Cita creada en estado Pending.");
                // Llama a GenerarTurnoForm y pásale el idCita
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la cita: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
