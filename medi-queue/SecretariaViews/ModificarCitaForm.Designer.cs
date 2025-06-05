namespace medi_queue.SecretariaViews
{
    partial class ModificarCitaForm
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
            btnRegresar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpCita = new DateTimePicker();
            txtSintomas = new TextBox();
            cmbEstado = new ComboBox();
            Estado = new Label();
            label1 = new Label();
            cmbDoctor = new ComboBox();
            txtNombre = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 15F);
            btnRegresar.Location = new Point(623, 249);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(148, 92);
            btnRegresar.TabIndex = 28;
            btnRegresar.Text = "Cancelar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 15F);
            btnGuardar.Location = new Point(623, 107);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 92);
            btnGuardar.TabIndex = 27;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(80, 126);
            label7.Name = "label7";
            label7.Size = new Size(133, 35);
            label7.TabIndex = 25;
            label7.Text = "Fecha Cita:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(91, 306);
            label3.Name = "label3";
            label3.Size = new Size(122, 35);
            label3.TabIndex = 21;
            label3.Text = "Síntomas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(101, 40);
            label2.Name = "label2";
            label2.Size = new Size(112, 35);
            label2.TabIndex = 20;
            label2.Text = "Paciente:";
            // 
            // dtpCita
            // 
            dtpCita.Font = new Font("Segoe UI", 15F);
            dtpCita.Location = new Point(254, 126);
            dtpCita.Name = "dtpCita";
            dtpCita.Size = new Size(304, 41);
            dtpCita.TabIndex = 19;
            // 
            // txtSintomas
            // 
            txtSintomas.Font = new Font("Segoe UI", 15F);
            txtSintomas.Location = new Point(254, 306);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(325, 41);
            txtSintomas.TabIndex = 16;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 15F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(254, 213);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 43);
            cmbEstado.TabIndex = 29;
            // 
            // Estado
            // 
            Estado.AutoSize = true;
            Estado.Font = new Font("Segoe UI", 15F);
            Estado.Location = new Point(118, 216);
            Estado.Name = "Estado";
            Estado.Size = new Size(95, 35);
            Estado.TabIndex = 30;
            Estado.Text = "Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(116, 388);
            label1.Name = "label1";
            label1.Size = new Size(97, 35);
            label1.TabIndex = 32;
            label1.Text = "Doctor:";
            // 
            // cmbDoctor
            // 
            cmbDoctor.Font = new Font("Segoe UI", 15F);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(254, 385);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(243, 43);
            cmbDoctor.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.Font = new Font("Segoe UI", 15F);
            txtNombre.Location = new Point(254, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(103, 35);
            txtNombre.TabIndex = 33;
            txtNombre.Text = "nombre";
            // 
            // ModificarCitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(cmbDoctor);
            Controls.Add(Estado);
            Controls.Add(cmbEstado);
            Controls.Add(btnRegresar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpCita);
            Controls.Add(txtSintomas);
            Name = "ModificarCitaForm";
            Text = "ModificarCitaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnGuardar;
        private ComboBox cmbGenero;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpCita;
        private TextBox txtDui;
        private TextBox txtApellido;
        private TextBox txtSintomas;
        private ComboBox cmbEstado;
        private Label Estado;
        private Label label1;
        private ComboBox cmbDoctor;
        private Label txtNombre;
    }
}