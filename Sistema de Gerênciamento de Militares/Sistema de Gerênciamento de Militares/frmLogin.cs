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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem Certeza?", " Sair ", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                MessageBox.Show("Saindo","....");
            }
            else
            {
                frmLogin TeladeLogin = new frmLogin();
                this.Hide();
                TeladeLogin.ShowDialog();
            }
            Application.Exit();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            if(txtbUsuarioLogin.Text == "Adan" && txtbSenhaLogin.Text == "Adan")
            {
               
               frmTelaInicial TelaInicial = new frmTelaInicial();
                this.Hide();
                TelaInicial.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha incorretos! Tente Novamente!", "ERROR");

            }
        }
    }
}
