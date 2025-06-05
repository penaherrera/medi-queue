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
    public partial class ModificarCitaForm : Form
    {
        public ModificarCitaForm()
        {
            InitializeComponent();
        }

        private int idCita;

        private string nombrePaciente;

        public ModificarCitaForm(int idCita, string nombrePaciente)
        {
            InitializeComponent();
            this.idCita = idCita;
            this.nombrePaciente = nombrePaciente;
            txtNombre.Text = nombrePaciente; // Mostrar el nombre en el TextBox
            CargarEstados();
            CargarDoctores();
            CargarDatosCita();
        }

        public ModificarCitaForm(int idCita)
        {
            InitializeComponent();
            this.idCita = idCita;
            CargarEstados();
            CargarDoctores();
            CargarDatosCita();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Pending");
            cmbEstado.Items.Add("Confirmed");
            cmbEstado.Items.Add("Finished");
        }

        private void CargarDoctores()
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand("SELECT IDDoctor, Name FROM Doctors", conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        cmbDoctor.DataSource = dt;
                        cmbDoctor.DisplayMember = "Name";
                        cmbDoctor.ValueMember = "IDDoctor";
                    }
                }
            }
        }

        private void CargarDatosCita()
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    @"SELECT a.DateTime, a.Status, a.Symptoms, a.IDDoctor
              FROM Appointments a
              WHERE a.IDAppointment = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idCita);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dtpCita.Value = Convert.ToDateTime(reader["DateTime"]);
                            txtSintomas.Text = reader["Symptoms"].ToString();
                            cmbEstado.SelectedItem = reader["Status"].ToString();
                            cmbDoctor.SelectedValue = Convert.ToInt32(reader["IDDoctor"]);
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"UPDATE Appointments SET 
                    DateTime = @DateTime,
                    Status = @Status,
                    Symptoms = @Symptoms,
                    IDDoctor = @IDDoctor
                  WHERE IDAppointment = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@DateTime", dtpCita.Value);
                        cmd.Parameters.AddWithValue("@Status", cmbEstado.SelectedItem?.ToString() ?? "Pending");
                        cmd.Parameters.AddWithValue("@Symptoms", txtSintomas.Text.Trim());
                        cmd.Parameters.AddWithValue("@IDDoctor", cmbDoctor.SelectedValue);
                        cmd.Parameters.AddWithValue("@ID", idCita);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Cita modificada correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la cita: " + ex.Message);
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
