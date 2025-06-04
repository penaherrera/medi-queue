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
    public partial class RegistrarSecretariasForm : Form
    {
        public RegistrarSecretariasForm()
        {
            InitializeComponent();
            cmbGenero.Items.AddRange(new[] { "Femenino", "Masculino" });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarSecretariasForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO Secretarias (Nombre, Apellido, Dui, FechaNacimiento, Genero, Telefono, Usuario, Contrasena) " +
                        "VALUES (@Nombre, @Apellido, @Dui, @FechaNacimiento, @Genero, @Telefono, @Usuario, @Contrasena)", conn);

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Dui", txtDui.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Genero", cmbGenero.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Secretaria registrada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar secretaria: " + ex.Message);
            }
        }
    }
}
