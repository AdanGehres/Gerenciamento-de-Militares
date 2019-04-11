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
    public partial class frmRelatorioAnual : Form
    {
        public frmRelatorioAnual()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmRelatorio TelaInicial = new frmRelatorio();
            this.Hide();
            TelaInicial.ShowDialog();
        }
    }
}
