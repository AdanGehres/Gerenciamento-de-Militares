using System;
using System.Collections;
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
            string ret = $"'{retorno.ToString("yyyy-M-dd HH:mm:ss")}'";

            if (retorno.ToString("HHmm") == "0000")
            {
                ret = "NULL";
            }


            string sql = $@"INSERT INTO gerenciamento
                               VALUES (DEFAULT
                                    ,  {militar}
                                    ,  '{motivo}'
                                    ,  '{saida.ToString("yyyy-MM-dd HH:mm:ss")}'
                                    ,  {ret});";

            return My.ExecuteNonQuery(sql);
        }

        public bool Update(DTOGerenciamento dto)
        {
            string sql = $@"UPDATE gerenciamento
                               SET motivo = '{dto.Motivo}'
                                 , saida = '{dto.Saida.ToString("yyyy-MM-dd HH:mm:ss")}'
                                 , retorno = '{dto.Retorno.ToString("yyyy-MM-dd HH:mm:ss")}'
                               WHERE id = {dto.Id}";

            return My.ExecuteNonQuery(sql);
        }

        public bool Delete(string id)
        {
            string sql = $@"DELETE FROM gerenciamento WHERE id = {id};";

            return My.ExecuteNonQuery(sql);
        }

        public DataTable GetTable(int id = 0)
        {
            DataTable dt = new DataTable();

            string sql = $@"SELECT g.id AS id
                                 , CONCAT(m.graduacao, ' ', m.nome) AS nome
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

        public ArrayList GetRelatorio(DateTime inicio, DateTime fim)
        {
            ArrayList array = new ArrayList();

            string sql = $@"SELECT *
                               FROM GERENCIAMENTO
                               WHERE saida >= '{inicio.ToString("yyyy-MM-dd")}'
                                 AND saida <= '{fim.ToString("yyyy-MM-dd")} 23:59:59';";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                while (My.ReadNextRecord())
                {
                    DTOGerenciamento dto = new DTOGerenciamento();
                    dto.Motivo = My.GetString("motivo");
                    dto.Saida = DateTime.ParseExact(My.GetString("saida"), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);

                    string retorno = My.GetString("retorno");
                    if (!string.IsNullOrEmpty(retorno))
                    {
                        dto.Retorno = DateTime.ParseExact(My.GetString("retorno"), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    }

                    Militar militar = new Militar();
                    dto.DTOMilitar = militar.GetDTO(My.GetString("id_militar"));

                    array.Add(dto);
                }
            }

            My.FechaConexao();

            return array;
        }

        public DTOGerenciamento GetDTO(string id)
        {
            DTOGerenciamento dto = new DTOGerenciamento();

            string sql = $@"SELECT *
                               FROM GERENCIAMENTO
                               WHERE id = {id};";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                My.ReadNextRecord();
                dto.Id = My.GetInt("id");
                dto.IdMilitar = My.GetInt("id_militar");
                dto.Motivo = My.GetString("motivo");

                dto.Saida = DateTime.ParseExact(My.GetString("saida"), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                dto.Retorno = DateTime.ParseExact(My.GetString("retorno"), "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            }

            My.FechaConexao();

            return dto;
        }
    }
}
