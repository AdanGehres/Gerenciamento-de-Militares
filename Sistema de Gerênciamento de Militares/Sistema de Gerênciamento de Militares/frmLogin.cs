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
    public partial class frmLogin : Form
    {
        private Usuario user;

        public frmLogin()
        {
            InitializeComponent();

            user = new Usuario();
        }

        private void btnSairLogin_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem Certeza?", " Sair ", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            if (user.UsuarioValido(txtbUsuarioLogin.Text, txtbSenhaLogin.Text))
            {
                this.DialogResult = DialogResult.OK;
                frmTelaInicial TelaInicial = new frmTelaInicial();
                this.Hide();
                TelaInicial.ShowDialog();

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Usuário ou Senha incorretos! Tente Novamente!", "ERROR");
            }
        }
    }
}
