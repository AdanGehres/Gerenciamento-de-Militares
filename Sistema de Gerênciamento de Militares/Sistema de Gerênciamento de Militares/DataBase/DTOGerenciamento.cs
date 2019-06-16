using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class DTOGerenciamento
    {
        public int Id { get; set; }

        public int IdMilitar { get; set; }

        public string Motivo { get; set; }

        public DateTime Saida { get; set; }

        public DateTime Retorno { get; set; }

        public DTOMilitar DTOMilitar { get; set; }
    }
}
