using medi_queue.database;
using medi_queue.DoctorViews;
using medi_queue.SecretariaViews;
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

namespace medi_queue
{
    public partial class SecretariaForm : Form
    {
        private int idSecretaria;

        public SecretariaForm(int idSecretaria)
        {
            InitializeComponent();
            this.idSecretaria = idSecretaria;
            // Aquí puedes usar idSecretaria para cargar información específica de la secretaria
            // Cargar pacientes pendientes de cita
            CargarPendientesCita();
            CargarColaEspera();
        }

        private void btnRegistroPacientes_Click(object sender, EventArgs e)
        {
            new RegistroPacientesForm().ShowDialog();
        }

        private void btnListaPacientes_Click(object sender, EventArgs e)
        {
            CargarColaEspera();
            new ListaPacientesForm().ShowDialog();
        }

        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            if (dgvPendientesCita.SelectedRows.Count > 0)
            {
                var row = dgvPendientesCita.SelectedRows[0];

                int idCita = Convert.ToInt32(row.Cells["IDAppointment"].Value);
                string paciente = row.Cells["Paciente"].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                string genero = row.Cells["Género"].Value.ToString();
                string telefono = row.Cells["Teléfono"].Value.ToString();
                DateTime fechaCita = Convert.ToDateTime(row.Cells["FechaCita"].Value);
                string estado = row.Cells["Estado"].Value.ToString();
                string sintomas = row.Cells["Symptoms"].Value.ToString();
                string doctor = row.Cells["Doctor"].Value.ToString();

                // Llama al formulario GenerarTurnoForm pasando todos los datos
                var turnoForm = new GenerarTurnoForm(
                    idCita, paciente, fechaNacimiento, genero, telefono, fechaCita, estado, sintomas, doctor
                );
                turnoForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una cita para generar el turno.");
            }
        }

        private void CargarPendientesCita()
        {
            // Lógica para cargar pacientes pendientes de cita en dgvPendientesCita
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
    a.Status AS Estado,
    a.Symptoms AS Symptoms,
    d.Name AS Doctor
 FROM Appointments a
 INNER JOIN Patients p ON a.IDPatient = p.IDPatient
 INNER JOIN Doctors d ON a.IDDoctor = d.IDDoctor
 WHERE a.Status = 'Pending'
 ORDER BY a.DateTime", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvPendientesCita.DataSource = dt;
                    dgvPendientesCita.Columns["IDAppointment"].Visible = false; // Oculta el ID visualmente
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }

    }
}
