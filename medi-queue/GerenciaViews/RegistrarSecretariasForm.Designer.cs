using medi_queue.database;
using Microsoft.Data.SqlClient;

namespace medi_queue.GerenciaViews
{
    partial class RegistrarSecretariasForm
    {
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

        public class Secretaria
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Dui { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Genero { get; set; }
            public string Telefono { get; set; }
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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            lblNombre = new Label();
            lblTelefono = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(219, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(219, 41);
            txtNombre.TabIndex = 0;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 15F);
            txtTelefono.Location = new Point(219, 141);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(219, 41);
            txtTelefono.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 15F);
            txtUsuario.Location = new Point(219, 234);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(219, 41);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 15F);
            txtContrasena.Location = new Point(219, 328);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(219, 41);
            txtContrasena.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(92, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(108, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 15F);
            lblTelefono.Location = new Point(92, 147);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(110, 35);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15F);
            lblUsuario.Location = new Point(100, 237);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(100, 35);
            lblUsuario.TabIndex = 10;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 15F);
            lblContraseña.Location = new Point(60, 328);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(140, 35);
            lblContraseña.TabIndex = 11;
            lblContraseña.Text = "Contraseña";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 15F);
            btnRegistrar.Location = new Point(519, 164);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(165, 99);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnGuardar_Click;
            // 
            // RegistrarSecretariasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblTelefono);
            Controls.Add(lblNombre);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Name = "RegistrarSecretariasForm";
            Text = "RegistrarSecretariasForm";
            Load += RegistrarSecretariasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label lblNombre;
        private Label lblTelefono;
        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnRegistrar;
    }
}