namespace medi_queue
{
    partial class GerenteForm
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
            btnRegistroCitas = new Button();
            btnDoctores = new Button();
            dgvColaEspera = new DataGridView();
            btnEliminarCita = new Button();
            btnModificarCita = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).BeginInit();
            SuspendLayout();
            // 
            // btnRegistroCitas
            // 
            btnRegistroCitas.Font = new Font("Segoe UI", 15F);
            btnRegistroCitas.Location = new Point(514, 61);
            btnRegistroCitas.Name = "btnRegistroCitas";
            btnRegistroCitas.Size = new Size(240, 91);
            btnRegistroCitas.TabIndex = 0;
            btnRegistroCitas.Text = "Registro de Citas";
            btnRegistroCitas.UseVisualStyleBackColor = true;
            btnRegistroCitas.Click += btnRegistroCitas_Click;
            // 
            // btnDoctores
            // 
            btnDoctores.Font = new Font("Segoe UI", 15F);
            btnDoctores.Location = new Point(508, 292);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(246, 84);
            btnDoctores.TabIndex = 2;
            btnDoctores.Text = "Registro de Doctores";
            btnDoctores.UseVisualStyleBackColor = true;
            btnDoctores.Click += btnRegistrarDoctor_Click;
            // 
            // dgvColaEspera
            // 
            dgvColaEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColaEspera.Location = new Point(23, 62);
            dgvColaEspera.Name = "dgvColaEspera";
            dgvColaEspera.RowHeadersWidth = 51;
            dgvColaEspera.Size = new Size(436, 269);
            dgvColaEspera.TabIndex = 4;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Font = new Font("Segoe UI", 15F);
            btnEliminarCita.Location = new Point(263, 348);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(127, 79);
            btnEliminarCita.TabIndex = 6;
            btnEliminarCita.Text = "Eliminar Cita";
            btnEliminarCita.UseVisualStyleBackColor = true;
            btnEliminarCita.Click += btnEliminarCita_Click;
            // 
            // btnModificarCita
            // 
            btnModificarCita.Font = new Font("Segoe UI", 15F);
            btnModificarCita.Location = new Point(79, 348);
            btnModificarCita.Name = "btnModificarCita";
            btnModificarCita.Size = new Size(149, 79);
            btnModificarCita.TabIndex = 5;
            btnModificarCita.Text = "Modificar Cita";
            btnModificarCita.UseVisualStyleBackColor = true;
            btnModificarCita.Click += btnModificarCita_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(514, 177);
            button1.Name = "button1";
            button1.Size = new Size(240, 85);
            button1.TabIndex = 8;
            button1.Text = "Registro de Secretarias";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegistrarSecretaria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(143, 15);
            label1.Name = "label1";
            label1.Size = new Size(193, 37);
            label1.TabIndex = 9;
            label1.Text = "Cola de Espera";
            // 
            // GerenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEliminarCita);
            Controls.Add(btnModificarCita);
            Controls.Add(dgvColaEspera);
            Controls.Add(btnDoctores);
            Controls.Add(btnRegistroCitas);
            Name = "GerenteForm";
            Text = "GerenteForm";
            Load += GerenteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).EndInit();
            ResumeLayout(false);
            PerformLayout();
            // ... (código existente)
        }

        #endregion

        private Button btnRegistroCitas;
        private Button btnDoctores;
        private DataGridView dgvColaEspera;
        private Button btnEliminarCita;
        private Button btnModificarCita;
        private Button button1;
        private Label label1;
    }

}