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

        public CitaEnCursoForm(dynamic cita)
        {
            InitializeComponent();
            // Mostrar datos del paciente
            lblNombre.Text = cita["Nombre"]?.ToString();
            lblApellido.Text = cita["Apellido"]?.ToString();
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
            // Guardar descripción y conclusiones en la base de datos si es necesario
            MessageBox.Show("Se ha concluido la cita.");
            this.Close();
        }
        public CitaEnCursoForm()
        {
            InitializeComponent();
        }

        private void CitaEnCursoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
