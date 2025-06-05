namespace medi_queue.GerenciaViews
{
    partial class ModificarForm
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
            dtpFechaCita = new DateTimePicker();
            cmbDoctores = new ComboBox();
            cmbEstado = new ComboBox();
            txtSintomas = new TextBox();
            btnRegresar = new Button();
            btnModificar = new Button();
            txtPaciente = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(390, 103);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(250, 27);
            dtpFechaCita.TabIndex = 0;
            // 
            // cmbDoctores
            // 
            cmbDoctores.FormattingEnabled = true;
            cmbDoctores.Location = new Point(390, 179);
            cmbDoctores.Name = "cmbDoctores";
            cmbDoctores.Size = new Size(151, 28);
            cmbDoctores.TabIndex = 1;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(390, 245);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 2;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(390, 310);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(319, 27);
            txtSintomas.TabIndex = 3;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 16F);
            btnRegresar.Location = new Point(237, 365);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(146, 60);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16F);
            btnModificar.Location = new Point(402, 365);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 57);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtPaciente
            // 
            txtPaciente.AutoSize = true;
            txtPaciente.Font = new Font("Segoe UI", 30F);
            txtPaciente.Location = new Point(330, 9);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(160, 67);
            txtPaciente.TabIndex = 7;
            txtPaciente.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(235, 96);
            label1.Name = "label1";
            label1.Size = new Size(133, 35);
            label1.TabIndex = 8;
            label1.Text = "Fecha Cita:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(271, 172);
            label2.Name = "label2";
            label2.Size = new Size(97, 35);
            label2.TabIndex = 9;
            label2.Text = "Doctor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(273, 245);
            label3.Name = "label3";
            label3.Size = new Size(95, 35);
            label3.TabIndex = 10;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(246, 302);
            label4.Name = "label4";
            label4.Size = new Size(122, 35);
            label4.TabIndex = 11;
            label4.Text = "Síntomas:";
            // 
            // ModificarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPaciente);
            Controls.Add(btnModificar);
            Controls.Add(btnRegresar);
            Controls.Add(txtSintomas);
            Controls.Add(cmbEstado);
            Controls.Add(cmbDoctores);
            Controls.Add(dtpFechaCita);
            Name = "ModificarForm";
            Text = "Modificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaCita;
        private ComboBox cmbDoctores;
        private ComboBox cmbEstado;
        private TextBox txtSintomas;
        private Button btnRegresar;
        private Button btnModificar;
        private Label txtPaciente;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}