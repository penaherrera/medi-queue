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
    public partial class GenerarTurnoForm : Form
    {
        private int idCita;
        public GenerarTurnoForm(
            int idCita,
            string paciente,
            DateTime fechaNacimiento,
            string genero,
            string telefono,
            DateTime fechaCita,
            string estado,
            string sintomas,
            string doctor)
        {
            InitializeComponent();
            this.idCita = idCita; // <-- Faltaba esta línea
                                  // Asigna los valores a los controles del formulario
            txtPaciente.Text = paciente;
            txtFechaNacimiento.Text = fechaNacimiento.ToShortDateString();
            txtGenero.Text = genero;
            txtSintomas.Text = sintomas;
            txtDoctor.Text = doctor;
        }

        private void CargarDoctores()
        {
            // Lógica para cargar doctores en cmbDoctores
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            // Suponiendo que tienes el ID de la cita (IDAppointment)
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"UPDATE Appointments SET Status = 'Confirmed' WHERE IDAppointment = @IDAppointment", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDAppointment", idCita); // idCita debe estar definido
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cita confirmada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al confirmar la cita: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
