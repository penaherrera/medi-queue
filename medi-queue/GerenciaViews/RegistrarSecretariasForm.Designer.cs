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
            txtApellido = new TextBox();
            txtDui = new TextBox();
            txtTelefono = new TextBox();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label7 = new Label();
            cmbGenero = new ComboBox();
            label8 = new Label();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(151, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(151, 171);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(125, 27);
            txtDui.TabIndex = 2;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(151, 243);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(151, 314);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(151, 372);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 103);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 178);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 8;
            label3.Text = "Dui";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 243);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 321);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 10;
            label5.Text = "Usuario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 379);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 11;
            label6.Text = "Contraseña";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(489, 47);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(188, 27);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(322, 50);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 13;
            label7.Text = "Fecha de Nacimiento";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbGenero.Location = new Point(500, 111);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(151, 28);
            cmbGenero.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 119);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Género";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(429, 204);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(165, 99);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // RegistrarSecretariasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(label8);
            Controls.Add(cmbGenero);
            Controls.Add(label7);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(txtTelefono);
            Controls.Add(txtDui);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "RegistrarSecretariasForm";
            Text = "RegistrarSecretariasForm";
            Load += RegistrarSecretariasForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDui;
        private TextBox txtTelefono;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Label label7;
        private ComboBox cmbGenero;
        private Label label8;
        private Button btnRegistrar;
    }
}