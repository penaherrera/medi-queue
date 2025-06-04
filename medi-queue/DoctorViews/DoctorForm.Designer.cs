namespace medi_queue
{
    partial class DoctorForm
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
            label1 = new Label();
            btnVerColaEspera = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnCambiarVista = new Button();
            btnIniciarCita = new Button();
            btnModificarCita = new Button();
            dgvColaEspera = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(119, 98);
            label1.Name = "label1";
            label1.Size = new Size(532, 54);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido (Nombre Doctor)";
            label1.Click += label1_Click;
            // 
            // btnVerColaEspera
            // 
            btnVerColaEspera.AutoSize = true;
            btnVerColaEspera.Font = new Font("Segoe UI", 20F);
            btnVerColaEspera.Location = new Point(296, 209);
            btnVerColaEspera.Name = "btnVerColaEspera";
            btnVerColaEspera.Size = new Size(250, 114);
            btnVerColaEspera.TabIndex = 4;
            btnVerColaEspera.Text = "Cola de Espera";
            btnVerColaEspera.UseVisualStyleBackColor = true;
            btnVerColaEspera.Click += btnCambiarVista_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnVerColaEspera);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(809, 452);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCambiarVista);
            panel2.Controls.Add(btnIniciarCita);
            panel2.Controls.Add(btnModificarCita);
            panel2.Controls.Add(dgvColaEspera);
            panel2.Location = new Point(2, 9);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 452);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // btnCambiarVista
            // 
            btnCambiarVista.Location = new Point(567, 303);
            btnCambiarVista.Name = "btnCambiarVista";
            btnCambiarVista.Size = new Size(195, 112);
            btnCambiarVista.TabIndex = 3;
            btnCambiarVista.Text = "Menu";
            btnCambiarVista.UseVisualStyleBackColor = true;
            btnCambiarVista.Click += btnCambiarVista_Click;
            // 
            // btnIniciarCita
            // 
            btnIniciarCita.Location = new Point(565, 158);
            btnIniciarCita.Name = "btnIniciarCita";
            btnIniciarCita.Size = new Size(197, 127);
            btnIniciarCita.TabIndex = 2;
            btnIniciarCita.Text = "Iniciar Cita";
            btnIniciarCita.UseVisualStyleBackColor = true;
            btnIniciarCita.Click += btnIniciarCita_Click;
            // 
            // btnModificarCita
            // 
            btnModificarCita.Location = new Point(565, 18);
            btnModificarCita.Name = "btnModificarCita";
            btnModificarCita.Size = new Size(197, 125);
            btnModificarCita.TabIndex = 1;
            btnModificarCita.Text = "Modificar Cita";
            btnModificarCita.UseVisualStyleBackColor = true;
            // 
            // dgvColaEspera
            // 
            dgvColaEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColaEspera.Location = new Point(13, 18);
            dgvColaEspera.Name = "dgvColaEspera";
            dgvColaEspera.RowHeadersWidth = 51;
            dgvColaEspera.Size = new Size(504, 397);
            dgvColaEspera.TabIndex = 0;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DoctorForm";
            Text = "DoctorForm";
            Load += DoctorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).EndInit();
            ResumeLayout(false);
        }
        private Label label1;
        private Button btnVerColaEspera;
        private Panel panel1;
        private Panel panel2;
        private Button btnIniciarCita;
        private Button btnModificarCita;
        private DataGridView dgvColaEspera;
        private Button btnCambiarVista;
    }
}