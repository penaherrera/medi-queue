using medi_queue.database;
using Microsoft.Data.SqlClient;
using System.Data;


namespace medi_queue.SecretariaViews
{
    partial class ListaPacientesForm
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
            dgvPacientesConCita = new DataGridView();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientesConCita).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientesConCita
            // 
            dgvPacientesConCita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientesConCita.Location = new Point(12, 51);
            dgvPacientesConCita.Name = "dgvPacientesConCita";
            dgvPacientesConCita.RowHeadersWidth = 51;
            dgvPacientesConCita.Size = new Size(776, 281);
            dgvPacientesConCita.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(215, 35);
            label1.TabIndex = 5;
            label1.Text = "Pacientes con Cita";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15F);
            btnEliminar.Location = new Point(388, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(400, 90);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar Cita Paciente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 15F);
            btnModificar.Location = new Point(12, 348);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(370, 90);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar Registro Cita";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // ListaPacientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label1);
            Controls.Add(dgvPacientesConCita);
            Name = "ListaPacientesForm";
            Text = "ListaPacientesForm";
            ((System.ComponentModel.ISupportInitialize)dgvPacientesConCita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientesConCita;
        private Label label1;
        private Button btnEliminar;
        private Button btnModificar;
    }
}