using Sistema_de_Gerênciamento_de_Militares.DataBase;
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
    public partial class frmConsultar : Form
    {
        private readonly Militar militar;
        private readonly Gerenciamento gerenciamento;

        public frmConsultar()
        {
            InitializeComponent();

            militar = new Militar();
            gerenciamento = new Gerenciamento();

            comboBox4 = militar.CBoxNomeMilitares(comboBox4);
            PreencherDGV();
        }

        #region Métodos Privados

        private void PreencherDGV()
        {
            dataGridView1.DataSource = gerenciamento.GetTable();
        }

        #endregion

        #region Botões

        private void BPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void BExcluir_Click(object sender, EventArgs e)
        {

        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
