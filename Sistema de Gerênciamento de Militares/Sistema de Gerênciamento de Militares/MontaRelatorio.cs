using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares
{
    public class MontaRelatorio
    {
        public int TamanhoLinha { get; set; }

        public MontaRelatorio()
        {
            TamanhoLinha = 80;
        }

        public MontaRelatorio(int tamanhoLinha)
        {
            TamanhoLinha = tamanhoLinha;
        }

        private string CortaTexto(int tamanho, string conteudo)
        {
            if (conteudo.Length > tamanho)
            {
                return conteudo.Substring(0, tamanho - 1);
            }

            return conteudo;
        }

        public string AddCollum(int tamanho, string conteudo)
        {
            string conteudoCortado = CortaTexto(tamanho, conteudo);
            return conteudoCortado.PadRight(tamanho, ' ');
        }

        public string CentralizaTexto(string conteudo)
        {
            int tamanhoTexto = conteudo.Length;
            int espacoSobrando = TamanhoLinha - tamanhoTexto;
            int espacoEsquerda = (espacoSobrando / 2) + tamanhoTexto;

            return conteudo.PadLeft(espacoEsquerda, ' ');
        }
    }
}
