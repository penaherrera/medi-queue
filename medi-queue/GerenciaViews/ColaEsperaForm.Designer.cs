namespace medi_queue.GerenciaViews
{
    partial class ColaEsperaForm
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
            dgvColaEspera = new DataGridView();
            btnModificarCita = new Button();
            btnEliminarCita = new Button();
            btnModificarDoctor = new Button();
            cmbFiltros = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).BeginInit();
            SuspendLayout();
            // 
            // dgvColaEspera
            // 
            dgvColaEspera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvColaEspera.Location = new Point(45, 37);
            dgvColaEspera.Name = "dgvColaEspera";
            dgvColaEspera.RowHeadersWidth = 51;
            dgvColaEspera.Size = new Size(300, 188);
            dgvColaEspera.TabIndex = 0;
            // 
            // btnModificarCita
            // 
            btnModificarCita.Location = new Point(390, 137);
            btnModificarCita.Name = "btnModificarCita";
            btnModificarCita.Size = new Size(94, 50);
            btnModificarCita.TabIndex = 1;
            btnModificarCita.Text = "Modificar Cita";
            btnModificarCita.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            btnEliminarCita.Location = new Point(512, 132);
            btnEliminarCita.Name = "btnEliminarCita";
            btnEliminarCita.Size = new Size(94, 55);
            btnEliminarCita.TabIndex = 2;
            btnEliminarCita.Text = "Eliminar Cita";
            btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // btnModificarDoctor
            // 
            btnModificarDoctor.Location = new Point(644, 130);
            btnModificarDoctor.Name = "btnModificarDoctor";
            btnModificarDoctor.Size = new Size(94, 57);
            btnModificarDoctor.TabIndex = 3;
            btnModificarDoctor.Text = "Modificar Doctor";
            btnModificarDoctor.UseVisualStyleBackColor = true;
            // 
            // cmbFiltros
            // 
            cmbFiltros.FormattingEnabled = true;
            cmbFiltros.Items.AddRange(new object[] { "Nombre", "Apellido", "Fecha Cita", "Tipo Cita" });
            cmbFiltros.Location = new Point(379, 37);
            cmbFiltros.Name = "cmbFiltros";
            cmbFiltros.Size = new Size(240, 28);
            cmbFiltros.TabIndex = 4;
            // 
            // ColaEsperaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbFiltros);
            Controls.Add(btnModificarDoctor);
            Controls.Add(btnEliminarCita);
            Controls.Add(btnModificarCita);
            Controls.Add(dgvColaEspera);
            Name = "ColaEsperaForm";
            Text = "ColaEsperaForm";
            Load += ColaEsperaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvColaEspera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvColaEspera;
        private Button btnModificarCita;
        private Button btnEliminarCita;
        private Button btnModificarDoctor;
        private ComboBox cmbFiltros;
    }
}