using medi_queue.GerenciaViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medi_queue
{
    public partial class GerenteForm : Form
    {
        public GerenteForm()
        {
            InitializeComponent();
        }

        private void btnSecretarias_Click(object sender, EventArgs e)
        {
            new RegistrarSecretariasForm().ShowDialog();
        }

        private void btnColaEspera_Click(object sender, EventArgs e)
        {
            new ColaEsperaForm().ShowDialog();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            new RegistrarDoctorForm().ShowDialog();
        }

        private void GerenteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
