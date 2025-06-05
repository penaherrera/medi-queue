namespace medi_queue.GerenciaViews
{
    partial class RegistroCitasForm
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
            dgvCitasFinalizadas = new DataGridView();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCitasFinalizadas).BeginInit();
            SuspendLayout();
            // 
            // dgvCitasFinalizadas
            // 
            dgvCitasFinalizadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasFinalizadas.Location = new Point(12, 12);
            dgvCitasFinalizadas.Name = "dgvCitasFinalizadas";
            dgvCitasFinalizadas.RowHeadersWidth = 51;
            dgvCitasFinalizadas.Size = new Size(776, 339);
            dgvCitasFinalizadas.TabIndex = 0;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 16F);
            btnRegresar.Location = new Point(320, 373);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(159, 65);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnSalir_Click;
            // 
            // RegistroCitasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(dgvCitasFinalizadas);
            Name = "RegistroCitasForm";
            Text = "RegistroCitasForm";
            ((System.ComponentModel.ISupportInitialize)dgvCitasFinalizadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCitasFinalizadas;
        private Button btnRegresar;
    }
}