using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_de_Gerênciamento_de_Militares.DataBase;

namespace Sistema_de_Gerênciamento_de_Militares
{
    public partial class frmCadastrarMilitar : Form
    {
        private Militar militar;

        public frmCadastrarMilitar()
        {
            InitializeComponent();

            militar = new Militar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdGrad1.Checked == true)
                txtGrad.Text = "Cb";
            else
                txtGrad.Text = "Sd";

            if (militar.AdicionaMilitar(txtGrad.Text, txtNome.Text))
            {
                MessageBox.Show("Militar salvo com sucesso!");
            }

            this.Close();
        }
    }
}
