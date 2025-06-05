using medi_queue.GerenciaViews;
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
    public partial class GerenteForm : Form
    {
        public GerenteForm()
        {
            InitializeComponent();
        }

        private string usuarioLogeado;

        public GerenteForm(string usuarioLogeado)
        {
            InitializeComponent();
            this.usuarioLogeado = usuarioLogeado;
        }

        private void GerenteForm_Load(object sender, EventArgs e)
        {
            CargarCitasPendientesYConfirmadas();
        }
        private void CargarCitasPendientesYConfirmadas()
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
                    a.DateTime AS FechaCita,
                    a.Status,
                    d.Name AS Doctor,
                    a.Symptoms AS Síntomas
                  FROM Appointments a
                  INNER JOIN Patients p ON a.IDPatient = p.IDPatient
                  INNER JOIN Doctors d ON a.IDDoctor = d.IDDoctor
                  WHERE a.Status IN ('Pending', 'Confirmed')
                  ORDER BY a.DateTime", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvColaEspera.DataSource = dt;
                    dgvColaEspera.Columns["IDAppointment"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las citas: " + ex.Message);
            }
        }


        private void btnSecretarias_Click(object sender, EventArgs e)
        {
            new RegistrarSecretariasForm().ShowDialog();
        }

        private void btnModificarCita_Click(object sender, EventArgs e)
        {
            if (dgvColaEspera.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dgvColaEspera.SelectedRows[0].Cells["IDAppointment"].Value);
                var modificarForm = new ModificarForm(idCita);
                if (modificarForm.ShowDialog() == DialogResult.OK)
                {
                    CargarCitasPendientesYConfirmadas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cita para modificar.");
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (dgvColaEspera.SelectedRows.Count > 0)
            {
                int idCita = Convert.ToInt32(dgvColaEspera.SelectedRows[0].Cells["IDAppointment"].Value);
                var result = MessageBox.Show("¿Está seguro que desea eliminar la cita seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();
                            using (var cmd = new SqlCommand("DELETE FROM Appointments WHERE IDAppointment = @ID", conn))
                            {
                                cmd.Parameters.AddWithValue("@ID", idCita);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Cita eliminada correctamente.");
                        CargarCitasPendientesYConfirmadas();
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

        private void btnRegistrarSecretaria_Click(object sender, EventArgs e)
        {
            var form = new RegistrarSecretariasForm();
            form.ShowDialog();
        }

        private void btnRegistrarDoctor_Click(object sender, EventArgs e)
        {
            var form = new RegistrarDoctorForm();
            form.ShowDialog();
        }

        private void btnRegistroCitas_Click(object sender, EventArgs e)
        {
            var registroCitasForm = new RegistroCitasForm();
            registroCitasForm.ShowDialog();
        }


    }
}
