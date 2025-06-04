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
            btnRegistrar = new Button();
            label8 = new Label();
            cmbGenero = new ComboBox();
            label7 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            txtTelefono = new TextBox();
            txtDui = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            cmbArea = new ComboBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(476, 267);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(165, 99);
            btnRegistrar.TabIndex = 33;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(428, 121);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 32;
            label8.Text = "Género";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbGenero.Location = new Point(511, 113);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(151, 28);
            cmbGenero.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 49);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 30;
            label7.Text = "Fecha de Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(511, 47);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(188, 27);
            dtpFechaNacimiento.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 381);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 28;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 323);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 27;
            label5.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 245);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 26;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 180);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 25;
            label3.Text = "Dui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 105);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 24;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 23;
            label1.Text = "Nombre";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(183, 374);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(125, 27);
            txtContrasena.TabIndex = 22;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(183, 316);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 21;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(183, 245);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 20;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(183, 173);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(125, 27);
            txtDui.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(183, 105);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 49);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 17;
            // 
            // cmbArea
            // 
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Medicina General / Familiar", "Pediatría", "Ginecología y Obstetricia", "Medicina Interna", "Odontología", "Psicología Clínica / Psiquiatría", "Laboratorio Clínico", "Radiología / Imagenología", "Dermatología", "Fisioterapia y Rehabilitación" });
            cmbArea.Location = new Point(511, 172);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(151, 28);
            cmbArea.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(445, 180);
            label9.Name = "label9";
            label9.Size = new Size(40, 20);
            label9.TabIndex = 35;
            label9.Text = "Área";
            // 
            // RegistrarDoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(cmbArea);
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

        private Button btnRegistrar;
        private Label label8;
        private ComboBox cmbGenero;
        private Label label7;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtTelefono;
        private TextBox txtDui;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private ComboBox cmbArea;
        private Label label9;
    }
}