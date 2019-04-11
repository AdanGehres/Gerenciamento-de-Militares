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
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTelaInicial TelaInicial = new frmTelaInicial();
            this.Hide();
            TelaInicial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNomedeGuerra.Text = "";
            txtData.Text = "";
            txtMotivo.Text = "";
            txtSaida.Text =  "";
            txtVolta.Text = "";
            rdbSoldado.Checked = false;
            rdbCabo.Checked = false;

        }
    }
}
