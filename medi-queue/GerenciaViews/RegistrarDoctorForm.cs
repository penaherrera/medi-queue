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
            cmbGenero.Items.AddRange(new[] { "Femenino", "Masculino" });
            // Llenar cmbArea con las áreas desde la base de datos
            CargarAreas();
        }

        private void CargarAreas()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT Id, Nombre FROM Areas", conn);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbArea.Items.Add(new
                            {
                                Id = reader.GetInt32(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                }
                cmbArea.DisplayMember = "Nombre";
                cmbArea.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar áreas: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "INSERT INTO Doctores (Nombre, Apellido, Dui, FechaNacimiento, Genero, Telefono, AreaId, Usuario, Contrasena) " +
                        "VALUES (@Nombre, @Apellido, @Dui, @FechaNacimiento, @Genero, @Telefono, @AreaId, @Usuario, @Contrasena)", conn);

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@Dui", txtDui.Text);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", dtpFechaNacimiento.Value);
                    cmd.Parameters.AddWithValue("@Genero", cmbGenero.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@AreaId", ((dynamic)cmbArea.SelectedItem).Id);
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Doctor registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar doctor: " + ex.Message);
            }
        }
    }
}
