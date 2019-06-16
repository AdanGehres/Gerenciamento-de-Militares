using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class DTOMilitar
    {
        public int Id { get; set; }

        public string Graduacao { get; set; }

        public string Nome { get; set; }

        public string GradNome {
            get
            {
                return $"{Graduacao} {Nome}";
            }
        }
    }
}
