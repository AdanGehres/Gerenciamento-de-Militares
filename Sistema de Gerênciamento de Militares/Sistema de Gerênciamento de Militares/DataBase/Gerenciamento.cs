using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class Gerenciamento
    {
        private readonly MySQL My;

        public Gerenciamento()
        {
            My = new MySQL();
        }

        public bool Insert(int militar, string motivo, DateTime saida, DateTime retorno)
        {
            string sql = $@"INSERT INTO gerenciamento
                               VALUES (DEFAULT
                                    ,  {militar}
                                    ,  '{motivo}'
                                    ,  '{saida.ToString("yyyy-MM-dd hh:mm:ss")}'
                                    ,  '{retorno.ToString("yyyy-M-dd hh:mm:ss")}');";

            return My.ExecuteNonQuery(sql);
        }
    }
}
