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

        private void button1_Click(object sender, EventArgs e)
        {

            frmRelatorio GerarRelatorio = new frmRelatorio();
            this.Hide();
            GerarRelatorio.ShowDialog();
        }

        

        

        private void btVoltar_Click(object sender, EventArgs e)
        {
            frmTelaInicial TelaInicial = new frmTelaInicial();
            this.Hide();
            TelaInicial.ShowDialog();
        }
    }
}
