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
        public SecretariaForm()
        {
            InitializeComponent();
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
            new GenerarTurnoForm().ShowDialog();
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
                    Nombre, 
                    Apellido, 
                    Edad, 
                    CASE [Género] WHEN 1 THEN 'Hombre' WHEN 2 THEN 'Mujer' ELSE 'Otro' END AS Género 
                  FROM Citas", conn))
                    {
                        using (var da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    dgvPendientesCita.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }

    }
}
