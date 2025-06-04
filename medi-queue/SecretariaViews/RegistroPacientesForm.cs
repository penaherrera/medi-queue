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
    public partial class RegistroPacientesForm : Form
    {
        public RegistroPacientesForm()
        {
            InitializeComponent();
            panel2.Visible = false;
            CargarPacientes();
            CargarColaEspera();
        }

        private void CargarPacientes()
        {
            // Lógica para cargar todos los pacientes en dgvPacientes
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            LimpiarFormulario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                panel2.Visible = true;
                // Cargar datos del paciente seleccionado en el formulario
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Desea eliminar el paciente seleccionado?", "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lógica para eliminar paciente
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Lógica para guardar o modificar paciente
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void LimpiarFormulario()
        {
            // Limpiar campos del formulario
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
                    dgvPacientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la cola de espera: " + ex.Message);
            }
        }
    }
}
