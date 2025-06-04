namespace medi_queue.SecretariaViews
{
    partial class RegistroPacientesForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbGenero = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtDui = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnCrear = new Button();
            dgvPacientes = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(dgvPacientes);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 451);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cmbGenero);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtpFechaNacimiento);
            panel2.Controls.Add(txtDui);
            panel2.Controls.Add(txtApellido);
            panel2.Controls.Add(txtTelefono);
            panel2.Controls.Add(txtNombre);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 454);
            panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(536, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(148, 92);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(536, 121);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(148, 92);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cmbGenero.Location = new Point(135, 253);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(151, 28);
            cmbGenero.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 320);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 11;
            label7.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 130);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 10;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 193);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 9;
            label5.Text = "Dui";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 253);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 8;
            label4.Text = "Género";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 381);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 7;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(195, 315);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(250, 27);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtDui
            // 
            txtDui.Location = new Point(135, 190);
            txtDui.Name = "txtDui";
            txtDui.Size = new Size(125, 27);
            txtDui.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(135, 123);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(135, 374);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(269, 14);
            label1.Name = "label1";
            label1.Size = new Size(255, 35);
            label1.TabIndex = 4;
            label1.Text = "Pacientes Registrados";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 15F);
            btnEliminar.Location = new Point(530, 348);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(259, 90);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar Registro Paciente";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 15F);
            btnModificar.Location = new Point(269, 348);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(255, 90);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar Registro Paciente";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 15F);
            btnCrear.Location = new Point(13, 348);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(250, 90);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear Registro Paciente";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(13, 62);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(776, 270);
            dgvPacientes.TabIndex = 0;
            // 
            // RegistroPacientesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "RegistroPacientesForm";
            Text = "RegistroPacientesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnCrear;
        private DataGridView dgvPacientes;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtApellido;
        private TextBox txtDui;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cmbGenero;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}