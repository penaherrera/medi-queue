using medi_queue.DoctorViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using medi_queue.database;
using Microsoft.Data.SqlClient;

namespace medi_queue
{
    public partial class DoctorForm : Form
    {
        private dynamic cita;

        public DoctorForm()
        {
            InitializeComponent();
            // Aquí puedes cargar la cola de espera al iniciar
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void btnCambiarVista_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                panel2.Visible = true;
                CargarColaEspera();
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }
        private void btnVerColaEspera_Click(object sender, EventArgs e)
        {
            CargarColaEspera();
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
                    Nombre, 
                    Apellido, 
                    Edad, 
                    CASE [Género] WHEN 1 THEN 'Hombre' WHEN 2 THEN 'Mujer' ELSE 'Otro' END AS Género, 
                    Fecha_Cita, 
                    [Síntomas], 
                    Doctor 
                  FROM Citas", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvColaEspera.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            // Lógica para modificar la cita seleccionada
        }

        private void btnIniciarCita_Click(object sender, EventArgs e)
        {
            if (dgvColaEspera.SelectedRows.Count > 0)
            {
                // Obtener datos de la cita seleccionada
                var cita = dgvColaEspera.SelectedRows[0].DataBoundItem;
                MessageBox.Show("Ha comenzado una nueva cita.\n\n");

                // Abrir la vista de la cita
                var citaForm = new CitaEnCursoForm(cita);
                citaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una cita para iniciar.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
