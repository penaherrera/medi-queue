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
    public partial class ModificarForm : Form
    {
        private int idCita;

        public ModificarForm(int idCita)
        {
            InitializeComponent();
            this.idCita = idCita;
            CargarEstados();
            CargarDatosCita();
            CargarDoctores();
            
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Pending");
            cmbEstado.Items.Add("Confirmed");
            cmbEstado.Items.Add("finished");
        }

        private void CargarDatosCita()
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    @"SELECT a.IDPatient, p.Name AS Paciente, a.IDDoctor, a.DateTime, a.Status, a.Symptoms
              FROM Appointments a
              INNER JOIN Patients p ON a.IDPatient = p.IDPatient
              WHERE a.IDAppointment = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", idCita);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dtpFechaCita.Value = Convert.ToDateTime(reader["DateTime"]);
                            txtSintomas.Text = reader["Symptoms"].ToString();
                            cmbDoctores.SelectedValue = Convert.ToInt32(reader["IDDoctor"]);
                            string status = reader["Status"].ToString();
                            if (cmbEstado.Items.Contains(status))
                                cmbEstado.SelectedItem = status;
                            else
                                cmbEstado.SelectedIndex = 0;

                            // Mostrar el nombre del paciente en un control (por ejemplo, un TextBox llamado txtPaciente)
                            txtPaciente.Text = reader["Paciente"].ToString();
                        }
                    }
                }
            }
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
                        cmbDoctores.DataSource = dt;
                        cmbDoctores.DisplayMember = "Name";
                        cmbDoctores.ValueMember = "IDDoctor";
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"UPDATE Appointments SET 
                    DateTime = @FechaCita,
                    IDDoctor = @IDDoctor,
                    Status = @Status,
                    Symptoms = @Sintomas
                  WHERE IDAppointment = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@FechaCita", dtpFechaCita.Value);
                        cmd.Parameters.AddWithValue("@IDDoctor", cmbDoctores.SelectedValue);
                        cmd.Parameters.AddWithValue("@Status", cmbEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Sintomas", txtSintomas.Text);
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
