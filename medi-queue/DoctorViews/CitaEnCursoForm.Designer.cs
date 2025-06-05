namespace medi_queue.DoctorViews
{
    partial class CitaEnCursoForm
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
            lblCronometro = new Label();
            lblSintomas = new Label();
            lblEdad = new Label();
            lblDoctor = new Label();
            lblNombre = new Label();
            lblGenero = new Label();
            lblFecha = new Label();
            txtDescripcionCita = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            txtConclusiones = new RichTextBox();
            btnFinalizarCita = new Button();
            SuspendLayout();
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Segoe UI", 20F);
            lblCronometro.Location = new Point(32, 27);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(0, 46);
            lblCronometro.TabIndex = 0;
            // 
            // lblSintomas
            // 
            lblSintomas.AutoSize = true;
            lblSintomas.Font = new Font("Segoe UI", 15F);
            lblSintomas.Location = new Point(32, 391);
            lblSintomas.Name = "lblSintomas";
            lblSintomas.Size = new Size(117, 35);
            lblSintomas.TabIndex = 2;
            lblSintomas.Text = "Síntomas";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 15F);
            lblEdad.Location = new Point(32, 194);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(71, 35);
            lblEdad.TabIndex = 3;
            lblEdad.Text = "Edad";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Segoe UI", 15F);
            lblDoctor.Location = new Point(32, 454);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(92, 35);
            lblDoctor.TabIndex = 4;
            lblDoctor.Text = "Doctor";
            lblDoctor.Click += lblDoctor_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(32, 128);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 35);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "nombre";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 15F);
            lblGenero.Location = new Point(32, 262);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(96, 35);
            lblGenero.TabIndex = 6;
            lblGenero.Text = "Género";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 15F);
            lblFecha.Location = new Point(32, 326);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(128, 35);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha Cita";
            // 
            // txtDescripcionCita
            // 
            txtDescripcionCita.Location = new Point(391, 70);
            txtDescripcionCita.Name = "txtDescripcionCita";
            txtDescripcionCita.Size = new Size(426, 120);
            txtDescripcionCita.TabIndex = 8;
            txtDescripcionCita.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(511, 25);
            label8.Name = "label8";
            label8.Size = new Size(195, 35);
            label8.TabIndex = 9;
            label8.Text = "Descripción Cita";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(522, 206);
            label9.Name = "label9";
            label9.Size = new Size(161, 35);
            label9.TabIndex = 10;
            label9.Text = "Conclusiones";
            // 
            // txtConclusiones
            // 
            txtConclusiones.Location = new Point(391, 262);
            txtConclusiones.Name = "txtConclusiones";
            txtConclusiones.Size = new Size(426, 120);
            txtConclusiones.TabIndex = 11;
            txtConclusiones.Text = "";
            // 
            // btnFinalizarCita
            // 
            btnFinalizarCita.Font = new Font("Segoe UI", 15F);
            btnFinalizarCita.Location = new Point(463, 415);
            btnFinalizarCita.Name = "btnFinalizarCita";
            btnFinalizarCita.Size = new Size(274, 50);
            btnFinalizarCita.TabIndex = 12;
            btnFinalizarCita.Text = "Finalizar Cita";
            btnFinalizarCita.UseVisualStyleBackColor = true;
            btnFinalizarCita.Click += btnFinalizarCita_Click;
            // 
            // CitaEnCursoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 508);
            Controls.Add(btnFinalizarCita);
            Controls.Add(txtConclusiones);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtDescripcionCita);
            Controls.Add(lblFecha);
            Controls.Add(lblGenero);
            Controls.Add(lblNombre);
            Controls.Add(lblDoctor);
            Controls.Add(lblEdad);
            Controls.Add(lblSintomas);
            Controls.Add(lblCronometro);
            Name = "CitaEnCursoForm";
            Text = "CitaEnCursoForm";
            Load += CitaEnCursoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCronometro;
        private Label lblSintomas;
        private Label lblEdad;
        private Label lblDoctor;
        private Label lblNombre;
        private Label lblGenero;
        private Label lblFecha;
        private RichTextBox txtDescripcionCita;
        private Label label8;
        private Label label9;
        private RichTextBox txtConclusiones;
        private Button btnFinalizarCita;
    }
}