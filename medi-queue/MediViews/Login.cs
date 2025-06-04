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

                    string query = "SELECT r.RoleName, r.IDRole FROM Users u " +
                                   "INNER JOIN Roles r ON u.IDRole = r.IDRole " +
                                   "WHERE u.Username = @username AND u.Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", txtPass.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var roleName = reader["RoleName"].ToString();
                                var idRole = reader["IDRole"].ToString();

                                MessageBox.Show($"Login success. Role: {roleName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                OpenFormBasedOnRole(idRole);
                            }
                            else
                            {
                                MessageBox.Show("Error in Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void OpenFormBasedOnRole(string idRole)
        {
            Form formToOpen = null;

            switch (idRole)
            {
                case "2":
                    formToOpen = new DoctorForm();
                    break;
                case "1":
                    formToOpen = new GerenteForm();
                    break;
                case "3":
                    formToOpen = new SecretariaForm();
                    break;
                default:
                    MessageBox.Show("Role not recognized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            this.Hide();
            formToOpen.ShowDialog();
            this.Show();
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
