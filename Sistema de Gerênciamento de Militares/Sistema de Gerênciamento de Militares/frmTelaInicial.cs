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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial(DTOUsuario dto)
        {
            InitializeComponent();

            if (!dto.IsAdmin)
            {
                sobreToolStripMenuItem1.Visible = false;
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarMilitar GerenciarMilitar = new frmGerenciarMilitar();
            GerenciarMilitar.ShowDialog();
        }

        private void sobreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar Consultar = new frmConsultar();
            Consultar.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarRelatorio Relatorios = new frmGerarRelatorio();
            Relatorios.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario CadastrarUsuario = new frmCadastrarUsuario();
            CadastrarUsuario.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza?", " Sair ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void cadastrarMilitaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarMilitar CadastrarMilitar = new frmCadastrarMilitar();
            CadastrarMilitar.ShowDialog();
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuário ConsultarUsuario = new frmConsultarUsuário();
            ConsultarUsuario.ShowDialog();
        }

        private void excluirEditarMilitaresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExcluirEditarMilitares ExlcuirEditarMilitares = new frmExcluirEditarMilitares();
            ExlcuirEditarMilitares.ShowDialog();
        }
    }
}
