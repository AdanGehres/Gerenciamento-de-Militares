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

        private void button1_Click(object sender, EventArgs e)
        {

            frmRelatorioSemanal RelatorioSemanal = new frmRelatorioSemanal();
            this.Hide();
            RelatorioSemanal.ShowDialog();
        }

        private void btRelatorioMensal_Click(object sender, EventArgs e)
        {

            frmRelatorioMensal RelatorioMensal = new frmRelatorioMensal();
            this.Hide();
            RelatorioMensal.ShowDialog();
        }

        private void btRelatorioAnual_Click(object sender, EventArgs e)
        {

            frmRelatorioAnual RelatorioAnual = new frmRelatorioAnual();
            this.Hide();
            RelatorioAnual.ShowDialog();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmTelaInicial TelaInicial = new frmTelaInicial();
            this.Hide();
            TelaInicial.ShowDialog();
        }
    }
}
