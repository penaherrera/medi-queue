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
            btnColaEspera = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(130, 71);
            label1.Name = "label1";
            label1.Size = new Size(532, 54);
            label1.TabIndex = 3;
            label1.Text = "Bienvenido (Nombre Doctor)";
            label1.Click += label1_Click;
            // 
            // btnColaEspera
            // 
            btnColaEspera.AutoSize = true;
            btnColaEspera.Font = new Font("Segoe UI", 20F);
            btnColaEspera.Location = new Point(293, 222);
            btnColaEspera.Name = "btnColaEspera";
            btnColaEspera.Size = new Size(250, 114);
            btnColaEspera.TabIndex = 4;
            btnColaEspera.Text = "Cola de Espera";
            btnColaEspera.UseVisualStyleBackColor = true;
            btnColaEspera.Click += label1_Click;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColaEspera);
            Controls.Add(label1);
            Name = "DoctorForm";
            Text = "DoctorForm";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Button btnColaEspera;
    }
}