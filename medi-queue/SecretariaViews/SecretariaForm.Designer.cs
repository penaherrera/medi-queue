namespace medi_queue
{
    partial class SecretariaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnRegistroPacientes = new Button();
            btnListaPacientes = new Button();
            btnGenerarTurno = new Button();
            dgvPendientesCita = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPendientesCita).BeginInit();
            SuspendLayout();
            // 
            // btnRegistroPacientes
            // 
            btnRegistroPacientes.Font = new Font("Segoe UI", 15F);
            btnRegistroPacientes.Location = new Point(12, 12);
            btnRegistroPacientes.Name = "btnRegistroPacientes";
            btnRegistroPacientes.Size = new Size(260, 101);
            btnRegistroPacientes.TabIndex = 0;
            btnRegistroPacientes.Text = "Registro de Pacientes";
            btnRegistroPacientes.UseVisualStyleBackColor = true;
            btnRegistroPacientes.Click += btnRegistroPacientes_Click;
            // 
            // btnListaPacientes
            // 
            btnListaPacientes.Font = new Font("Segoe UI", 15F);
            btnListaPacientes.Location = new Point(278, 12);
            btnListaPacientes.Name = "btnListaPacientes";
            btnListaPacientes.Size = new Size(260, 101);
            btnListaPacientes.TabIndex = 1;
            btnListaPacientes.Text = "Lista de Pacientes";
            btnListaPacientes.UseVisualStyleBackColor = true;
            btnListaPacientes.Click += btnListaPacientes_Click;
            // 
            // btnGenerarTurno
            // 
            btnGenerarTurno.Font = new Font("Segoe UI", 15F);
            btnGenerarTurno.Location = new Point(544, 12);
            btnGenerarTurno.Name = "btnGenerarTurno";
            btnGenerarTurno.Size = new Size(244, 101);
            btnGenerarTurno.TabIndex = 2;
            btnGenerarTurno.Text = "Generar Turno de Cita";
            btnGenerarTurno.UseVisualStyleBackColor = true;
            btnGenerarTurno.Click += btnGenerarTurno_Click;
            // 
            // dgvPendientesCita
            // 
            dgvPendientesCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPendientesCita.Location = new Point(12, 183);
            dgvPendientesCita.Name = "dgvPendientesCita";
            dgvPendientesCita.RowHeadersWidth = 51;
            dgvPendientesCita.Size = new Size(776, 255);
            dgvPendientesCita.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(223, 130);
            label1.Name = "label1";
            label1.Size = new Size(354, 37);
            label1.TabIndex = 4;
            label1.Text = "Pacientes Pendientes de Cita";
            // 
            // SecretariaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvPendientesCita);
            Controls.Add(btnGenerarTurno);
            Controls.Add(btnListaPacientes);
            Controls.Add(btnRegistroPacientes);
            Name = "SecretariaForm";
            Text = "SecretariaForm";
            ((System.ComponentModel.ISupportInitialize)dgvPendientesCita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnRegistroPacientes;
        private Button btnListaPacientes;
        private Button btnGenerarTurno;
        private DataGridView dgvPendientesCita;
        private Label label1;
    }
}
