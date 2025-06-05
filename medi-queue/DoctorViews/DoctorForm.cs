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
        private int idDoctor;

        public DoctorForm(int idDoctor)
        {
            InitializeComponent();
            this.idDoctor = idDoctor;
            // Aquí puedes usar idDoctor para cargar información específica del doctor
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
    a.IDAppointment,
    p.Name AS Paciente,
    DATEDIFF(YEAR, p.BirthDate, GETDATE()) AS Edad,
    CASE p.Gender WHEN 'M' THEN 'Hombre' WHEN 'F' THEN 'Mujer' ELSE 'Otro' END AS Género,
    a.DateTime AS Fecha_Cita,
    a.Symptoms AS Síntomas,
    d.Name AS Doctor
  FROM Appointments a
  INNER JOIN Patients p ON a.IDPatient = p.IDPatient
  INNER JOIN Doctors d ON a.IDDoctor = d.IDDoctor
  WHERE a.Status = 'Confirmed' AND a.IDDoctor = @IDDoctor
  ORDER BY a.DateTime", conn))
                    {
                        cmd.Parameters.AddWithValue("@IDDoctor", idDoctor);
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvColaEspera.DataSource = dt;
                    dgvColaEspera.Columns["IDAppointment"].Visible = false; // Opcional: ocultar la columna en la vista
                    if (dgvColaEspera.Columns.Contains("Apellido"))
                    {
                        dgvColaEspera.Columns["Apellido"].Visible = false;
                    }

                    if (dgvColaEspera.SelectedRows.Count > 0)
                    {
                        var cita = dgvColaEspera.SelectedRows[0].DataBoundItem; // DataRowView
                        var citaForm = new CitaEnCursoForm(cita);
                        citaForm.ShowDialog();
                    }
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
