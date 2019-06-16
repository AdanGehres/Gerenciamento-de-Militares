using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class DTOUsuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Tipo { get; set; }

        public string Senha { get; set; }

        public bool IsAdmin {
            get
            {
                return Tipo == 2;
            }
        }
    }
}
