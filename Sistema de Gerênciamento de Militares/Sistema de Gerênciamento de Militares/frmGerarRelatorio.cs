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
    public partial class frmGerarRelatorio : Form
    {

        private Gerenciamento gerenciamento;

        public frmGerarRelatorio()
        {
            InitializeComponent();

            gerenciamento = new Gerenciamento();
        }

        private void BtRelatorioSemanal_Click(object sender, EventArgs e)
        {
            RelatorioSemanal rel = new RelatorioSemanal();
            MontaRelatorio montaRel = new MontaRelatorio();

            DateTime inicio = dateTimePicker1.Value;
            DateTime fim = dateTimePicker2.Value;

            rel.AddCabecalho(montaRel.CentralizaTexto("1ª BATERIA DE OBUSES"));
            rel.AddLinha(" ");
            rel.AddCabecalho(montaRel.CentralizaTexto("MINISTÉRIO DA DEFESA"));
            rel.AddCabecalho(montaRel.CentralizaTexto("EXÉRCITO BRASILEIRO"));
            rel.AddCabecalho(montaRel.CentralizaTexto("13º GRUPO DE ARTILHARIA DE CAMPANHA"));
            rel.AddCabecalho(montaRel.CentralizaTexto("GRUPO GENERAL POLIDORO"));
            rel.AddLinha(" ");
            rel.AddLinha(" ");

            rel.AddLinha($"Relatório de {inicio.ToShortDateString()} à {fim.ToShortDateString()}");

            string cabecalho = montaRel.AddCollum(20, "Militar")
                             + montaRel.AddCollum(23, "Motivo")
                             + montaRel.AddCollum(20, "Saída")
                             + montaRel.AddCollum(20, "Retorno");

            rel.AddCabecalho(cabecalho);

            foreach (DTOGerenciamento dto in gerenciamento.GetRelatorio(inicio, fim))
            {
                string retorno = dto.Retorno.ToString("HH:mm dd/MM/yyyy");
                if (dto.Retorno.ToString("HHmm") == "0000")
                {
                    retorno = string.Empty;
                }
                string linha = montaRel.AddCollum(20, dto.DTOMilitar.GradNome)
                             + montaRel.AddCollum(23, dto.Motivo)
                             + montaRel.AddCollum(20, dto.Saida.ToString("HH:mm dd/MM/yyyy"))
                             + montaRel.AddCollum(20, retorno);

                rel.AddLinha(linha);
            }

            rel.FinalizaRelatorio();
        }



        private void BtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
