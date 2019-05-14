using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerênciamento_de_Militares
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmGerarRelatorio TelaInicial = new frmGerarRelatorio();
            this.Hide();
            TelaInicial.ShowDialog();
        }
    }
}
