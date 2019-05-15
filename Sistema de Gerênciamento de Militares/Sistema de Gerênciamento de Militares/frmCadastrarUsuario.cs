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
    public partial class frmCadastrarUsuario : Form
    {
        private Usuario user;

        public frmCadastrarUsuario()
        {
            InitializeComponent();

            user = new Usuario();
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSalvar_Click(object sender, EventArgs e)
        {
            if (user.AdicionaUsuario(txtUsuario.Text, txtSenha.Text))
            {
                MessageBox.Show("Usuário adicionado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Houve um erro ao cadastrar usuário");
            }
        }
    }
}
