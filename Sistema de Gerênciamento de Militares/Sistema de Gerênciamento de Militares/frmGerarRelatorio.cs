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
    public partial class frmGerarRelatorio : Form
    {
        public frmGerarRelatorio()
        {
            InitializeComponent();
        }

        private void BtRelatorioSemanal_Click(object sender, EventArgs e)
        {
            RelatorioSemanal rel = new RelatorioSemanal();
            rel.GeraRelatorio();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
