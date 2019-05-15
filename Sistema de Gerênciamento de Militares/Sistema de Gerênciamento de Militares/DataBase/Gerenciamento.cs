using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable GetTable(int id = 0)
        {
            DataTable dt = new DataTable();

            string sql = $@"SELECT CONCAT(m.graduacao, ' ', m.nome) AS nome
                                 , g.motivo AS motivo
                                 , g.saida AS saida
                                 , g.retorno AS retorno

                               FROM gerenciamento AS g
                               INNER JOIN militar AS m
                                  ON g.id_militar = m.id";

            if (id != 0) sql += $" WHERE m.id = {id};";

            dt = My.GetDataTable(sql);

            My.FechaConexao();
            return dt;
        }
    }
}
