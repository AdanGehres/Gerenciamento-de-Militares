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

        private int idMilitar = 0;

        public frmCadastrarMilitar()
        {
            InitializeComponent();
            militar = new Militar();
        }

        public frmCadastrarMilitar(DTOMilitar militarEdit)
        {
            InitializeComponent();
            militar = new Militar();

            idMilitar = militarEdit.Id;
            txtNome.Text = militarEdit.Nome;

            rdGrad1.Checked = militarEdit.Graduacao == "Cb";
            rdGrad2.Checked = militarEdit.Graduacao == "Sd";
        }

        /// <summary>
        /// Voltar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Salvar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (rdGrad1.Checked == true)
                txtGrad.Text = "Cb";
            else
                txtGrad.Text = "Sd";

            bool sucesso;

            if (idMilitar > 0) //Edição
            {
                sucesso = militar.EditaMilitar(idMilitar, txtGrad.Text, txtNome.Text);
            }
            else //Novo militar
            {
                sucesso = militar.AdicionaMilitar(txtGrad.Text, txtNome.Text);
            }

            if (sucesso)
            {
                MessageBox.Show("Militar salvo com sucesso!");
            }

            this.Close();
        }

        private void frmCadastrarMilitar_Load(object sender, EventArgs e)
        {

        }
    }
}
