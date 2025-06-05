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

namespace medi_queue.DoctorViews
{
    public partial class CitaEnCursoForm : Form
    {
        private System.Windows.Forms.Timer timer; // Explicitly specify the namespace to resolve ambiguity
        private DateTime inicioCita;
        private dynamic cita;

        public CitaEnCursoForm(dynamic cita)
        {
            InitializeComponent();
            this.cita = cita;
            // Mostrar datos del paciente
            lblNombre.Text = cita["Paciente"]?.ToString();
            lblEdad.Text = cita["Edad"]?.ToString();
            lblGenero.Text = cita["Género"]?.ToString();
            lblFecha.Text = Convert.ToDateTime(cita["Fecha_Cita"]).ToString("dd/MM/yyyy");
            lblSintomas.Text = cita["Síntomas"]?.ToString();
            lblDoctor.Text = cita["Doctor"]?.ToString();

            // Iniciar cronómetro
            inicioCita = DateTime.Now;
            timer = new System.Windows.Forms.Timer(); // Explicitly specify the namespace
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var transcurrido = DateTime.Now - inicioCita;
            lblCronometro.Text = transcurrido.ToString(@"hh\:mm\:ss");
        }

        private void btnFinalizarCita_Click(object sender, EventArgs e)
        {
            timer.Stop();

            // Obtener los datos de la cita
            string paciente = lblNombre.Text;
            int edad = int.TryParse(lblEdad.Text, out int eVal) ? eVal : 0;
            string genero = lblGenero.Text;
            DateTime fechaCita = DateTime.ParseExact(lblFecha.Text, "dd/MM/yyyy", null);
            string sintomas = lblSintomas.Text;
            string doctor = lblDoctor.Text;
            string tiempoTranscurrido = lblCronometro.Text;
            string descripcion = txtDescripcionCita.Text;
            string conclusiones = txtConclusiones.Text;

            // Suponiendo que tienes el IDAppointment en el objeto cita
            int idAppointment = cita["IDAppointment"];

            try
            {
                using (var conn = medi_queue.database.DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Insertar en RegistrosCitas
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO RegistrosCitas 
                    (IDAppointment, Paciente, Edad, Genero, FechaCita, Sintomas, Doctor, TiempoTranscurrido, Descripcion, Conclusiones)
                  VALUES
                    (@IDAppointment, @Paciente, @Edad, @Genero, @FechaCita, @Sintomas, @Doctor, @TiempoTranscurrido, @Descripcion, @Conclusiones)", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDAppointment", idAppointment);
                        cmd.Parameters.AddWithValue("@Paciente", paciente);
                        cmd.Parameters.AddWithValue("@Edad", edad);
                        cmd.Parameters.AddWithValue("@Genero", genero);
                        cmd.Parameters.AddWithValue("@FechaCita", fechaCita);
                        cmd.Parameters.AddWithValue("@Sintomas", sintomas);
                        cmd.Parameters.AddWithValue("@Doctor", doctor);
                        cmd.Parameters.AddWithValue("@TiempoTranscurrido", tiempoTranscurrido);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@Conclusiones", conclusiones);
                        cmd.ExecuteNonQuery();
                    }

                    // Actualizar el estado de la cita a "finished"
                    using (var cmd = new SqlCommand(
                        @"UPDATE Appointments SET Status = 'finished' WHERE IDAppointment = @IDAppointment", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDAppointment", idAppointment);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Se ha concluido y registrado la cita.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro de la cita: " + ex.Message);
            }
        }
        public CitaEnCursoForm()
        {
            InitializeComponent();
        }

        private void CitaEnCursoForm_Load(object sender, EventArgs e)
        {

        }

        private void lblDoctor_Click(object sender, EventArgs e)
        {

        }
    }
}
