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
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            frmGerenciarMilitar GerenciarMilitar= new frmGerenciarMilitar();
            this.Hide();
            GerenciarMilitar.ShowDialog();
        }



        private void sobreToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            this.Hide();
            Sobre.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultar Consultar = new frmConsultar();
            this.Hide();
            Consultar.ShowDialog();
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerarRelatorio Relatorios = new frmGerarRelatorio();
            this.Hide();
            Relatorios.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarUsuario CadastrarUsuario= new frmCadastrarUsuario();
            this.Hide();
            CadastrarUsuario.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza?", " Sair ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Saindo", "....");
            }
            else
            {
                frmTelaInicial TelaInicial = new frmTelaInicial();
                this.Hide();
                TelaInicial.ShowDialog();
            }
            Application.Exit();

        }

        private void cadastrarMilitaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarMilitar CadastrarMilitar= new frmCadastrarMilitar();
            this.Hide();
            CadastrarMilitar.ShowDialog();
        }

        private void excluirUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUsuário ConsultarUsuário = new frmConsultarUsuário();
            this.Hide();
            ConsultarUsuário.ShowDialog();
        }

        private void excluirEditarMilitaresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExcluirEditarMilitares ExlcuirEditarMilitares = new frmExcluirEditarMilitares();
            this.Hide();
            ExlcuirEditarMilitares.ShowDialog();
        }  
    }
}
