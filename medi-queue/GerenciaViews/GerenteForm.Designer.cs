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
            btSecretarias = new Button();
            btnColaEspera = new Button();
            btnDoctores = new Button();
            SuspendLayout();
            // 
            // btSecretarias
            // 
            btSecretarias.Location = new Point(181, 143);
            btSecretarias.Name = "btSecretarias";
            btSecretarias.Size = new Size(94, 55);
            btSecretarias.TabIndex = 0;
            btSecretarias.Text = "Registro de Secretarias";
            btSecretarias.UseVisualStyleBackColor = true;
            btSecretarias.Click += btnSecretarias_Click;
            // 
            // btnColaEspera
            // 
            btnColaEspera.Location = new Point(356, 146);
            btnColaEspera.Name = "btnColaEspera";
            btnColaEspera.Size = new Size(94, 52);
            btnColaEspera.TabIndex = 1;
            btnColaEspera.Text = "Ver Cola de Espera";
            btnColaEspera.UseVisualStyleBackColor = true;
            btnColaEspera.Click += btnColaEspera_Click;
            // 
            // btnDoctores
            // 
            btnDoctores.Location = new Point(556, 154);
            btnDoctores.Name = "btnDoctores";
            btnDoctores.Size = new Size(94, 53);
            btnDoctores.TabIndex = 2;
            btnDoctores.Text = "Registro de Doctores";
            btnDoctores.UseVisualStyleBackColor = true;
            btnDoctores.Click += btnDoctores_Click;
            // 
            // GerenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoctores);
            Controls.Add(btnColaEspera);
            Controls.Add(btSecretarias);
            Name = "GerenteForm";
            Text = "GerenteForm";
            Load += GerenteForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btSecretarias;
        private Button btnColaEspera;
        private Button btnDoctores;
    }

}