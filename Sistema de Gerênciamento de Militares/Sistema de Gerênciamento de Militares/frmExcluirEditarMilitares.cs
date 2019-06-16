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
    public partial class frmExcluirEditarMilitares : Form
    {

        private Militar militar;

        public frmExcluirEditarMilitares()
        {
            InitializeComponent();

            militar = new Militar();

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridView1.DataSource = militar.GetDataTable();
        }

        #region Botões

        /// <summary>
        /// Editar Militar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            //Obtém o nome do militar selecionado pelo usuário
            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

            DTOMilitar militarAtual = militar.GetDTO(id);

            frmCadastrarMilitar cad = new frmCadastrarMilitar(militarAtual);
            cad.ShowDialog();

            //Atualiza a tela
            AtualizaDataGrid();
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            //Obtém o ID da linha selecionada pelo usuário
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (militar.ExcluiMilitar(id))
            {
                MessageBox.Show("Militar excluído com sucesso");
                AtualizaDataGrid();
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir o militar!");
            }
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
