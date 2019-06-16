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
    public partial class frmConsultarUsuário : Form
    {

        private Usuario user;

        public frmConsultarUsuário()
        {
            InitializeComponent();

            user = new Usuario();

            AtualizaDataGrid();
        }

        private void AtualizaDataGrid()
        {
            dataGridView1.DataSource = user.GetDataTable();
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BExcluir_Click(object sender, EventArgs e)
        {
            //Verifica se o usuário selecionou uma linha
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

                if (user.DeletaUsuario(id))
                {
                    MessageBox.Show("Usuário excluído com sucesso");
                    AtualizaDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao excluir usuário");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();

            frmCadastrarUsuario frm = new frmCadastrarUsuario(user.GetDTO(id));
            frm.ShowDialog();

            AtualizaDataGrid();
        }
    }
}
