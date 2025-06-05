using medi_queue.database;
using Microsoft.Data.SqlClient;

namespace medi_queue.GerenciaViews
{
    partial class RegistrarDoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public class Doctor
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Dui { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Genero { get; set; }
            public string Telefono { get; set; }
            public int AreaId { get; set; }
            public string Usuario { get; set; }
            public string Contrasena { get; set; }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardar = new Button();
            lblContraseña = new Label();
            lblUsuario = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblEspecialidad = new Label();
            txtEspecialidad = new TextBox();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.Location = new Point(547, 174);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(165, 99);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Registrar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 15F);
            lblContraseña.Location = new Point(89, 281);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(140, 35);
            lblContraseña.TabIndex = 24;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15F);
            lblUsuario.Location = new Point(129, 206);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 35);
            lblUsuario.TabIndex = 23;
            lblUsuario.Text = "Usuario";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 15F);
            lblTelefono.Location = new Point(129, 128);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(110, 35);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(131, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(108, 35);
            lblNombre.TabIndex = 21;
            lblNombre.Text = "Nombre";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 15F);
            txtContrasena.Location = new Point(261, 279);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(208, 41);
            txtContrasena.TabIndex = 20;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 15F);
            txtUsuario.Location = new Point(261, 205);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 41);
            txtUsuario.TabIndex = 19;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15F);
            txtTelefono.Location = new Point(261, 128);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(208, 41);
            txtTelefono.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(261, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 41);
            txtNombre.TabIndex = 17;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 15F);
            lblEspecialidad.Location = new Point(76, 350);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(153, 35);
            lblEspecialidad.TabIndex = 27;
            lblEspecialidad.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.Font = new Font("Segoe UI", 15F);
            txtEspecialidad.Location = new Point(261, 350);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(208, 41);
            txtEspecialidad.TabIndex = 26;
            // 
            // RegistrarDoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEspecialidad);
            Controls.Add(txtEspecialidad);
            Controls.Add(btnGuardar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "RegistrarDoctorForm";
            Text = "RegistrarDoctorForm";
            Load += RegistrarDoctorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void RegistrarDoctorForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private Button btnGuardar;
        private Label lblContraseña;
        private Label lblUsuario;
        private Label lblTelefono;
        private Label lblNombre;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private Label lblEspecialidad;
        private TextBox txtEspecialidad;
    }
}