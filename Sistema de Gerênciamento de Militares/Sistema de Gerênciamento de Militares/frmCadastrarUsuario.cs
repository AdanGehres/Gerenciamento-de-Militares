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

        private int idUsuario = 0;

        public frmCadastrarUsuario()
        {
            InitializeComponent();

            user = new Usuario();
        }

        public frmCadastrarUsuario(DTOUsuario dto)
        {
            InitializeComponent();
            user = new Usuario();

            idUsuario = dto.Id;
            txtUsuario.Text = dto.Nome;
            txtSenha.Text = dto.Senha;

            rdAdmin.Checked = dto.IsAdmin;
            rdUsu.Checked = !dto.IsAdmin;
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BSalvar_Click(object sender, EventArgs e)
        {
            DTOUsuario dto = new DTOUsuario
            {
                Id = idUsuario,
                Nome = txtUsuario.Text,
                Senha = txtSenha.Text,
                Tipo = rdAdmin.Checked ? 2 : 1 // Admin 2 | User 1
            };

            bool sucesso;
            if (idUsuario > 0)
            {
                sucesso = user.EditaUsuario(dto);
            }
            else
            {
                sucesso = user.AdicionaUsuario(dto);
            }

            if (sucesso)
            {
                MessageBox.Show("Usuário salvo com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Houve um erro ao cadastrar usuário");
            }
        }
    }
}
