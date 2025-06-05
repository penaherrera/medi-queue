using Microsoft.Data.SqlClient;
using medi_queue.database;
using System;

namespace medi_queue
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string query = @"SELECT u.id, u.username, u.IDRole, r.RoleName
                                     FROM Users u
                                     INNER JOIN Roles r ON u.IDRole = r.IDRole
                                     WHERE u.Username = @username AND u.Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var idUser = Convert.ToInt32(reader["id"]);
                                var roleName = reader["RoleName"].ToString();
                                var idRole = reader["IDRole"].ToString();

                                MessageBox.Show($"Login success. Rol: {roleName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpenFormBasedOnUser(idUser, idRole);
                            }
                            else
                            {
                                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenFormBasedOnUser(int idUser, string idRole)
        {
            Form formToOpen = null;

            switch (idRole)
            {
                case "3": // Doctor
                    {
                        int idDoctor = GetDoctorIdByUserId(idUser);
                        if (idDoctor > 0)
                            formToOpen = new DoctorForm(idDoctor);
                        else
                        {
                            MessageBox.Show("No se encontró el doctor asociado a este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                case "2": // Secretaria
                    {
                        int idSecretaria = GetSecretaryIdByUserId(idUser);
                        if (idSecretaria > 0)
                            formToOpen = new SecretariaForm(idSecretaria);
                        else
                        {
                            MessageBox.Show("No se encontró la secretaria asociada a este usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                case "1": // Gerente
                    formToOpen = new GerenteForm();
                    break;
                default:
                    MessageBox.Show("Rol no reconocido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            this.Hide();
            formToOpen.ShowDialog();
            this.Show();
        }

        private int GetDoctorIdByUserId(int userId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT IDDoctor FROM Doctors WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private int GetSecretaryIdByUserId(int userId)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT IDSecretary FROM Secretaries WHERE UserID = @UserID", conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    var result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}
