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
        private dynamic paciente;
        public GenerarTurnoForm(dynamic pacienteSeleccionado = null)
        {
            InitializeComponent();
            paciente = pacienteSeleccionado;
            if (paciente != null)
            {
                // Mostrar datos del paciente en los campos correspondientes
            }
            CargarDoctores();
        }

        private void CargarDoctores()
        {
            // Lógica para cargar doctores en cmbDoctores
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            // Validar y registrar cita
            bool datosValidos = true; // Implementar validación real
            if (datosValidos)
            {
                // Lógica para registrar cita en la base de datos
                MessageBox.Show("Cita creada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Verificar todos los datos de la cita.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
