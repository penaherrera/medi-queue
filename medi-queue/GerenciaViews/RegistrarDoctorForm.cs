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
    public partial class RegistrarDoctorForm : Form
    {
        public RegistrarDoctorForm()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombre = txtNombre.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string username = nombre.Replace(" ", "").ToLower();
            string password = username.Replace(" ", "").ToLower();

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                // Crear usuario
                int idRole = GetRoleId("Doctor", conn);
                int userId;
                using (var cmd = new SqlCommand(
                    "INSERT INTO Users (username, password, IDRole) OUTPUT INSERTED.id VALUES (@username, @password, @idRole)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@idRole", idRole);
                    userId = (int)cmd.ExecuteScalar();
                }
                // Crear doctor
                using (var cmd = new SqlCommand(
                    "INSERT INTO Doctors (Name, Specialty, PhoneNumber, IDRole, UserID) VALUES (@name, @specialty, @phone, @idRole, @userId)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", nombre);
                    cmd.Parameters.AddWithValue("@specialty", txtEspecialidad.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", telefono);
                    cmd.Parameters.AddWithValue("@idRole", idRole);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Doctor registrado correctamente.");
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
