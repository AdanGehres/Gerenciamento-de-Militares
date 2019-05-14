using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class Usuario
    {
        private MySQL My;

        public Usuario()
        {
            My = new MySQL();
        }

        public bool UsuarioValido(string user, string pass)
        {
            bool ret = false;
            string sql = $@"SELECT ID
                               FROM usuario
                               WHERE nome = '{user}'
                                 AND senha = '{pass}';";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                ret = true;
            }

            My.FechaConexao();
            return ret;
        }
    }
}
