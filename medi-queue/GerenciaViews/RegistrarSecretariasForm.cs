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
        }


        private void RegistrarSecretariasForm_Load(object sender, EventArgs e)
        {
 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string username = txtUsuario.Text.Trim();
            string password = txtContrasena.Text.Trim();

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // Obtener el ID del rol de secretaria
                int idRole = GetRoleId("Secretaria", conn);
                int userId;
                // Insertar en Users
                using (var cmd = new SqlCommand(
                    "INSERT INTO Users (Username, Password, IDRole) OUTPUT INSERTED.ID VALUES (@username, @password, @idRole)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@idRole", idRole);
                    userId = (int)cmd.ExecuteScalar();
                }
                // Insertar en Secretaries
                using (var cmd = new SqlCommand(
                    "INSERT INTO Secretaries (Name, PhoneNumber, IDRole, UserID) VALUES (@name, @phone, @idRole, @userId)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", nombre);
                    cmd.Parameters.AddWithValue("@phone", telefono);
                    cmd.Parameters.AddWithValue("@idRole", idRole);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Secretaria registrada correctamente.");
            this.Close();
        }

        private int GetRoleId(string roleName, SqlConnection conn)
        {
            using (var cmd = new SqlCommand("SELECT IDRole FROM Roles WHERE RoleName = @role", conn))
            {
                cmd.Parameters.AddWithValue("@role", roleName);
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
