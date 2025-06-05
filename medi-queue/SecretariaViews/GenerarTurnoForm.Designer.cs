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
            txtGenero = new Label();
            txtPaciente = new Label();
            txtDoctor = new Label();
            txtFechaNacimiento = new Label();
            txtSintomas = new Label();
            btnRegistrarCita = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtGenero
            // 
            txtGenero.AutoSize = true;
            txtGenero.Font = new Font("Segoe UI", 15F);
            txtGenero.Location = new Point(250, 249);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(96, 35);
            txtGenero.TabIndex = 13;
            txtGenero.Text = "Género";
            // 
            // txtPaciente
            // 
            txtPaciente.AutoSize = true;
            txtPaciente.Font = new Font("Segoe UI", 15F);
            txtPaciente.Location = new Point(250, 59);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(103, 35);
            txtPaciente.TabIndex = 12;
            txtPaciente.Text = "nombre";
            // 
            // txtDoctor
            // 
            txtDoctor.AutoSize = true;
            txtDoctor.Font = new Font("Segoe UI", 15F);
            txtDoctor.Location = new Point(590, 182);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(92, 35);
            txtDoctor.TabIndex = 11;
            txtDoctor.Text = "Doctor";
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.AutoSize = true;
            txtFechaNacimiento.Font = new Font("Segoe UI", 15F);
            txtFechaNacimiento.Location = new Point(250, 156);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(71, 35);
            txtFechaNacimiento.TabIndex = 10;
            txtFechaNacimiento.Text = "Edad";
            // 
            // txtSintomas
            // 
            txtSintomas.AutoSize = true;
            txtSintomas.Font = new Font("Segoe UI", 15F);
            txtSintomas.Location = new Point(581, 68);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(117, 35);
            txtSintomas.TabIndex = 9;
            txtSintomas.Text = "Síntomas";
            // 
            // btnRegistrarCita
            // 
            btnRegistrarCita.Font = new Font("Segoe UI", 15F);
            btnRegistrarCita.Location = new Point(164, 338);
            btnRegistrarCita.Name = "btnRegistrarCita";
            btnRegistrarCita.Size = new Size(223, 76);
            btnRegistrarCita.TabIndex = 18;
            btnRegistrarCita.Text = "Registrar Cita";
            btnRegistrarCita.UseVisualStyleBackColor = true;
            btnRegistrarCita.Click += btnRegistrarCita_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15F);
            btnSalir.Location = new Point(419, 338);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 76);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(119, 59);
            label1.Name = "label1";
            label1.Size = new Size(112, 35);
            label1.TabIndex = 20;
            label1.Text = "Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(219, 35);
            label2.TabIndex = 21;
            label2.Text = "Fecha Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(130, 249);
            label3.Name = "label3";
            label3.Size = new Size(101, 35);
            label3.TabIndex = 22;
            label3.Text = "Género:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(438, 68);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 23;
            label4.Text = "Síntomas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(463, 182);
            label5.Name = "label5";
            label5.Size = new Size(97, 35);
            label5.TabIndex = 24;
            label5.Text = "Doctor:";
            // 
            // GenerarTurnoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarCita);
            Controls.Add(txtGenero);
            Controls.Add(txtPaciente);
            Controls.Add(txtDoctor);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtSintomas);
            Name = "GenerarTurnoForm";
            Text = "GenerarTurnoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label txtGenero;
        private Label txtPaciente;
        private Label txtDoctor;
        private Label txtFechaNacimiento;
        private Label txtSintomas;
        private Button btnRegistrarCita;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}