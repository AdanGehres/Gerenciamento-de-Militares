using MySql.Data.MySqlClient;
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
            if (ValidaUsu(txtbUsuarioLogin.Text, txtbSenhaLogin.Text))
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
                                 

            //if(txtbUsuarioLogin.Text == "Adan" && txtbSenhaLogin.Text == "Adan")
            //{
               
            //   frmTelaInicial TelaInicial = new frmTelaInicial();
            //    this.Hide();
            //    TelaInicial.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou Senha incorretos! Tente Novamente!", "ERROR");

            //}
        }

        private bool ValidaUsu(string usuario, string senha)
        {
            int retorno = -1;

            MySqlConnection conn = new MySqlConnection(@"server=127.0.0.1;database=gerenciamento militar;Uid=root;");
            string comando = "SELECT COUNT(*) FROM usuario WHERE Usuario=@Usuario AND senha=@Senha";

            MySqlCommand cmd = new MySqlCommand(comando, conn);

            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);

            conn.Open();

            retorno = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return retorno > 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
