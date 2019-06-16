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
            AtualizaDataGrid();
        }

        #region Métodos Privados

        private void AtualizaDataGrid()
        {
            if (!string.IsNullOrEmpty(comboBox4.Text))
            {
                int id = militar.GetIdByName(comboBox4.Text);
                dataGridView1.DataSource = gerenciamento.GetTable(id);
            }
            else
            {
                dataGridView1.DataSource = gerenciamento.GetTable();
            }
        }

        #endregion

        #region Botões

        private void BExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se usuário selecionou alguma linha
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                if (gerenciamento.Delete(id))
                {
                    MessageBox.Show("Registro deletado com sucesso!");
                    AtualizaDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao deletar o registro");
                }
            }
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizaDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
