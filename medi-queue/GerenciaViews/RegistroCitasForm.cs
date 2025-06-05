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

namespace medi_queue.GerenciaViews
{
    public partial class RegistroCitasForm : Form
    {
        public RegistroCitasForm()
        {
            InitializeComponent();
            this.Load += RegistroCitasForm_Load;
        }

        private void RegistroCitasForm_Load(object sender, EventArgs e)
        {
            CargarCitasFinalizadas();

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CargarCitasFinalizadas()
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
                d.Name AS Doctor,
                a.Symptoms AS Síntomas,
                a.Status AS Estado
              FROM Appointments a
              INNER JOIN Patients p ON a.IDPatient = p.IDPatient
              INNER JOIN Doctors d ON a.IDDoctor = d.IDDoctor
              WHERE a.Status = 'finished'
              ORDER BY a.DateTime", conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                dgvCitasFinalizadas.DataSource = dt;
                dgvCitasFinalizadas.Columns["IDAppointment"].Visible = false;
            }
        }
    }
}
