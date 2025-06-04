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
    public partial class ListaPacientesForm : Form
    {
        public ListaPacientesForm()
        {
            InitializeComponent();
            CargarPacientesConCita();
            CargarColaEspera();
        }

        private void CargarPacientesConCita()
        {
            // Lógica para cargar pacientes con cita en dgvPacientesConCita
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Lógica para modificar paciente seleccionado
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar paciente seleccionado
        }

        private void btnCrearCita_Click(object sender, EventArgs e)
        {
            if (dgvPacientesConCita.SelectedRows.Count > 0)
            {
                var paciente = dgvPacientesConCita.SelectedRows[0].DataBoundItem;
                new GenerarTurnoForm(paciente).ShowDialog();
            }
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
                    dgvPacientesConCita.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }
    }
}
