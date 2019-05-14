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

namespace Sistema_de_Gerênciamento_de_Militares
{
    public partial class frmCadastrarMilitar : Form
    {
        public frmCadastrarMilitar()
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
            MySqlConnection conn = new MySqlConnection(@"server=127.0.0.1;database=gerenciamento militar;Uid=root;");

            conn.Open();
            if (rdGrad1.Checked == true)
              txtGrad.Text = "Cb";
            else
              txtGrad.Text = "Sd";


            string comando = "INSERT INTO MILITAR(GRADUACAO, NOME)" + "VALUES ('" + txtGrad.Text + "','" + txtNome.Text + "')";

            MySqlCommand cmd = new MySqlCommand(comando, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("CADASTRO SALVO COM SUCESSO!");

            graduacao11.Text = "";

            frmTelaInicial TelaInicial = new frmTelaInicial();
            this.Hide();
            TelaInicial.ShowDialog();
        }
    }
}
