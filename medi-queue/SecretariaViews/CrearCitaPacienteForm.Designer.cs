namespace medi_queue.SecretariaViews
{
    partial class CrearCitaPacienteForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnRegistrarCita = new Button();
            txtGenero = new Label();
            txtNombre = new Label();
            txtFechaNacimiento = new Label();
            dtpFechaCita = new DateTimePicker();
            lblFecha = new Label();
            txtTelefono = new Label();
            txtSintomas = new RichTextBox();
            lblSintomas = new Label();
            cmbDoctores = new ComboBox();
            lblDoctor = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15F);
            btnSalir.Location = new Point(448, 375);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 63);
            btnSalir.TabIndex = 31;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrarCita
            // 
            btnRegistrarCita.Font = new Font("Segoe UI", 15F);
            btnRegistrarCita.Location = new Point(210, 375);
            btnRegistrarCita.Name = "btnRegistrarCita";
            btnRegistrarCita.Size = new Size(202, 63);
            btnRegistrarCita.TabIndex = 30;
            btnRegistrarCita.Text = "Guardar Cita";
            btnRegistrarCita.UseVisualStyleBackColor = true;
            btnRegistrarCita.Click += btnGuardar_Click;
            // 
            // txtGenero
            // 
            txtGenero.AutoSize = true;
            txtGenero.Font = new Font("Segoe UI", 15F);
            txtGenero.Location = new Point(131, 183);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(96, 35);
            txtGenero.TabIndex = 25;
            txtGenero.Text = "Género";
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(131, 18);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(103, 35);
            txtNombre.TabIndex = 24;
            txtNombre.Text = "nombre";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.AutoSize = true;
            txtFechaNacimiento.Font = new Font("Segoe UI", 15F);
            txtFechaNacimiento.Location = new Point(238, 100);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(214, 35);
            txtFechaNacimiento.TabIndex = 22;
            txtFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Font = new Font("Segoe UI", 14F);
            dtpFechaCita.Location = new Point(468, 201);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(284, 39);
            dtpFechaCita.TabIndex = 27;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(319, 201);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(133, 35);
            lblFecha.TabIndex = 26;
            lblFecha.Text = "Fecha Cita:";
            // 
            // txtTelefono
            // 
            txtTelefono.AutoSize = true;
            txtTelefono.Font = new Font("Segoe UI", 15F);
            txtTelefono.Location = new Point(131, 281);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(110, 35);
            txtTelefono.TabIndex = 32;
            txtTelefono.Text = "Teléfono";
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(594, 18);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(194, 117);
            txtSintomas.TabIndex = 34;
            txtSintomas.Text = "";
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 15F);
            lblSintomas.Location = new Point(448, 18);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(122, 35);
            lblSintomas.TabIndex = 33;
            lblSintomas.Text = "Síntomas:";
            // 
            // cmbDoctores
            // 
            cmbDoctores.Font = new Font("Segoe UI", 15F);
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(468, 298);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(284, 43);
            cmbDoctores.TabIndex = 36;
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 15F);
            lblDoctor.Location = new Point(349, 301);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(97, 35);
            lblDoctor.TabIndex = 35;
            lblDoctor.Text = "Doctor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 35);
            label1.TabIndex = 37;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(13, 100);
            label2.Name = "label2";
            label2.Size = new Size(219, 35);
            label2.TabIndex = 38;
            label2.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 183);
            label3.Name = "label3";
            label3.Size = new Size(101, 35);
            label3.TabIndex = 39;
            label3.Text = "Género:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(10, 281);
            label4.Name = "label4";
            label4.Size = new Size(115, 35);
            label4.TabIndex = 40;
            label4.Text = "Teléfono:";
            // 
            // CrearCitaPacienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDoctores);
            Controls.Add(lblDoctor);
            Controls.Add(txtSintomas);
            Controls.Add(lblSintomas);
            Controls.Add(txtTelefono);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarCita);
            Controls.Add(dtpFechaCita);
            Controls.Add(lblFecha);
            Controls.Add(txtGenero);
            Controls.Add(txtNombre);
            Controls.Add(txtFechaNacimiento);
            Name = "CrearCitaPacienteForm";
            Text = "CrearCitaPacienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnRegistrarCita;
        private Label txtGenero;
        private Label txtNombre;
        private Label txtFechaNacimiento;
        private DateTimePicker dtpFechaCita;
        private Label lblFecha;
        private Label txtTelefono;
        private RichTextBox txtSintomas;
        private Label lblSintomas;
        private ComboBox cmbDoctores;
        private Label lblDoctor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}