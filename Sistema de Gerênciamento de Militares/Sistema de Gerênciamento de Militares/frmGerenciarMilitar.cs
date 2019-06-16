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

        private int idGerenciamento = 0;

        public frmGerenciarMilitar()
        {
            InitializeComponent();

            militar = new Militar();
            gerenciamento = new Gerenciamento();

            cmbNomedeGuerra = militar.CBoxNomeMilitares(cmbNomedeGuerra);
            LimparTela();
        }

        public frmGerenciarMilitar(DTOGerenciamento dto)
        {
            InitializeComponent();
            militar = new Militar();
            gerenciamento = new Gerenciamento();

            idGerenciamento = dto.Id;

            DTOMilitar dtoMilitar = militar.GetDTO(dto.IdMilitar.ToString());
            cmbNomedeGuerra.Items.Add(dtoMilitar.GradNome);
            cmbNomedeGuerra.SelectedIndex = 0;
            cmbNomedeGuerra.Enabled = false;

            txtMotivo.Text = dto.Motivo;
            dtpSaida.Value = dto.Saida;
            dtpVolta.Value = dto.Retorno;
        }

        #region Botões
        private void BSalvar(object sender, EventArgs e)
        {
            if (TelaValida())
            {
                DateTime saida =  dtpSaida.Value;
                DateTime volta =  dtpVolta.Value;

                int id = militar.GetIdByName(cmbNomedeGuerra.Text);

                bool sucesso;

                if(idGerenciamento > 0) //Edição
                {
                    DTOGerenciamento dto = new DTOGerenciamento
                    {
                        Id = idGerenciamento,
                        Motivo = txtMotivo.Text,
                        Saida = saida,
                        Retorno = volta
                    };

                    sucesso = gerenciamento.Update(dto);
                }
                else //novo gerenciamento
                {
                    sucesso = gerenciamento.Insert(militar: id, motivo: txtMotivo.Text, saida: saida, retorno: volta);
                }

                if(sucesso)
                {
                    MessageBox.Show("Gerenciamento salvo com sucesso!");
                    LimparTela();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar");
                }
            }
            this.Close();
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
            cmbNomedeGuerra.SelectedIndex = -1;
            txtMotivo.Text = "";
            dtpSaida.Value = Convert.ToDateTime("00:00");
            dtpVolta.Value = Convert.ToDateTime("00:00");
        }

        private bool TelaValida()
        {
            if (!CampoPreenchido(cmbNomedeGuerra, "Nome de Guerra")) return false;
            //if (!CampoPreenchido(txtMotivo, "Motivo")) return false;
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

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpSaida_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
