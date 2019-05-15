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
    public partial class frmGerenciarMilitar : Form
    {
        /// <summary>
        /// Objeto com os métodos da tabela 'militar' no BD
        /// </summary>
        private readonly Militar militar;

        /// <summary>
        /// Objeto com os métodos da tabela 'gerenciamento' no BD
        /// </summary>
        private readonly Gerenciamento gerenciamento;

        public frmGerenciarMilitar()
        {
            InitializeComponent();

            militar = new Militar();
            gerenciamento = new Gerenciamento();

            cmbNomedeGuerra = militar.CBoxNomeMilitares(cmbNomedeGuerra);
            LimparTela();
        }

        #region Botões
        private void BSalvar(object sender, EventArgs e)
        {
            if (TelaValida())
            {
                DateTime saida = MontaData(dtpData.Value, dtpSaida.Value);
                DateTime volta = MontaData(dtpData.Value, dtpVolta.Value);

                int id = militar.GetIdByName(cmbNomedeGuerra.Text);

                if(gerenciamento.Insert(militar: id, motivo: txtMotivo.Text, saida: saida, retorno: volta))
                {
                    MessageBox.Show("Gerenciamento salvo com sucesso!");
                    LimparTela();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar");
                }
            }
        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void BVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Métodos Privados

        private DateTime MontaData(DateTime data, DateTime hora)
        {
            return new DateTime(data.Year, data.Month, data.Day, hora.Hour, hora.Minute, hora.Second);
        }

        private void LimparTela()
        {
            cmbNomedeGuerra.Text = "";
            dtpData.Value = DateTime.Now;
            txtMotivo.Text = "";
            dtpSaida.Value = Convert.ToDateTime("00:00");
            dtpVolta.Value = Convert.ToDateTime("00:00");
        }

        private bool TelaValida()
        {
            if (!CampoPreenchido(cmbNomedeGuerra, "Nome de Guerra")) return false;
            if (!CampoPreenchido(dtpData, "Data de Saída")) return false;
            if (!CampoPreenchido(txtMotivo, "Motivo")) return false;
            if (!CampoPreenchido(dtpSaida, "Horário de Saída")) return false;
            if (!CampoPreenchido(dtpVolta, "Horário de Volta")) return false;

            return true;
        }

        private bool CampoPreenchido(DateTimePicker obj, string campo)
        {
            //Se o campo está preenchido, retorna verdadeiro
            if (!string.IsNullOrEmpty(obj.Value.ToString())) return true;

            MessageBox.Show($"Campo {campo} não preenchido!");
            obj.Focus();
            return false;
        }

        private bool CampoPreenchido(ComboBox obj, string campo)
        {
            //Se o campo está preenchido, retorna verdadeiro
            if (!string.IsNullOrEmpty(obj.Text)) return true;

            MessageBox.Show($"Campo {campo} não preenchido!");
            obj.Focus();
            return false;
        }

        private bool CampoPreenchido(TextBox obj, string campo)
        {
            //Se o campo está preenchido, retorna verdadeiro
            if (!string.IsNullOrEmpty(obj.Text)) return true;

            MessageBox.Show($"Campo '{campo}' não preenchido!");
            obj.Focus();
            return false;
        }

        #endregion
    }
}
