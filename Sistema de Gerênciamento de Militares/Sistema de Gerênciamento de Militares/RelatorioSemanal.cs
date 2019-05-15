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
        public void GeraRelatorio()
        {
            //Cria documento e estipula tipo da folha
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80); //Tamanho das margens
            doc.AddCreationDate(); //Adiciona as configurações

            //caminho onde sera criado o pdf + nome desejado
            //OBS: o nome sempre deve ser terminado com .pdf
            string caminho = @"relatorio.pdf";

            //criando o arquivo pdf embranco, passando como parametro a variavel                
            //doc criada acima e a variavel caminho 
            //tambem criada acima.
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //criando uma string vazia
            string dados = "";

            //criando a variavel para paragrafo
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14))
            {
                Alignment = Element.ALIGN_JUSTIFIED
            };


            paragrafo.Add("TESTE TESTE TESTE");
            
            doc.Add(paragrafo);
            
            doc.Close();

            System.Diagnostics.Process.Start(caminho);
        }
    }
}
