using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bibliotecas para o iTextSharp
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Sistema_de_Gerênciamento_de_Militares
{
    public class RelatorioSemanal
    {

        private Document doc;

        public string Caminho { get; set; }

        public RelatorioSemanal()
        {
            //Cria documento e estipula tipo da folha
            doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80); //Tamanho das margens
            doc.AddCreationDate(); //Adiciona as configurações

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            Caminho = @"relatorio.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel                
            //doc criada acima e a variavel caminho 
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(Caminho, FileMode.Create));

            doc.Open();
        }

        public void AddCabecalho(string conteudoLinha)
        {
            BaseFont font = BaseFont.CreateFont(BaseFont.COURIER_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Paragraph paragrafo = new Paragraph("", new Font(font, 10))
            {
                Alignment = Element.ALIGN_JUSTIFIED
            };

            paragrafo.Add(conteudoLinha);
            doc.Add(paragrafo);
        }

        public void AddLinha(string conteudoLinha)
        {
            Paragraph paragrafo = new Paragraph("", new Font(Font.NORMAL, 10))
            {
                Alignment = Element.ALIGN_JUSTIFIED
            };

            paragrafo.Add(conteudoLinha);
            doc.Add(paragrafo);
        }

        public void FinalizaRelatorio()
        {
            doc.Close();

            System.Diagnostics.Process.Start(Caminho);
        }
    }
}
