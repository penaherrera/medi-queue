namespace medi_queue.SecretariaViews
{
    partial class GenerarTurnoForm
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
            lblFecha = new Label();
            lblGenero = new Label();
            lblNombre = new Label();
            lblDoctor = new Label();
            lblEdad = new Label();
            lblSintomas = new Label();
            lblApellido = new Label();
            dtpFechaCita = new DateTimePicker();
            txtSintomas = new RichTextBox();
            cmbDoctores = new ComboBox();
            btnRegistrarCita = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(342, 34);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(128, 35);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Fecha Cita";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 15F);
            lblGenero.Location = new Point(64, 207);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(96, 35);
            lblGenero.TabIndex = 13;
            lblGenero.Text = "Género";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(64, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 35);
            lblNombre.TabIndex = 12;
            lblNombre.Text = "nombre";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 15F);
            lblDoctor.Location = new Point(367, 269);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(92, 35);
            lblDoctor.TabIndex = 11;
            lblDoctor.Text = "Doctor";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 15F);
            lblEdad.Location = new Point(64, 152);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(71, 35);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad";
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 15F);
            lblSintomas.Location = new Point(342, 140);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(117, 35);
            lblSintomas.TabIndex = 9;
            lblSintomas.Text = "Síntomas";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 15F);
            lblApellido.Location = new Point(64, 97);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 35);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(517, 41);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(250, 27);
            dtpFechaCita.TabIndex = 15;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(479, 126);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(279, 74);
            txtSintomas.TabIndex = 16;
            txtSintomas.Text = "";
            // 
            // cmbDoctores
            // 
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(517, 278);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(191, 28);
            cmbDoctores.TabIndex = 17;
            // 
            // btnRegistrarCita
            // 
            btnRegistrarCita.Location = new Point(188, 362);
            btnRegistrarCita.Name = "btnRegistrarCita";
            btnRegistrarCita.Size = new Size(180, 29);
            btnRegistrarCita.TabIndex = 18;
            btnRegistrarCita.Text = "Registrar Cita";
            btnRegistrarCita.UseVisualStyleBackColor = true;
            btnRegistrarCita.Click += btnRegistrarCita_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(466, 362);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // GenerarTurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarCita);
            Controls.Add(cmbDoctores);
            Controls.Add(txtSintomas);
            Controls.Add(dtpFechaCita);
            Controls.Add(lblFecha);
            Controls.Add(lblGenero);
            Controls.Add(lblNombre);
            Controls.Add(lblDoctor);
            Controls.Add(lblEdad);
            Controls.Add(lblSintomas);
            Controls.Add(lblApellido);
            Name = "GenerarTurnoForm";
            Text = "GenerarTurnoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private Label lblGenero;
        private Label lblNombre;
        private Label lblDoctor;
        private Label lblEdad;
        private Label lblSintomas;
        private Label lblApellido;
        private DateTimePicker dtpFechaCita;
        private RichTextBox txtSintomas;
        private ComboBox cmbDoctores;
        private Button btnRegistrarCita;
        private Button btnSalir;
    }
}