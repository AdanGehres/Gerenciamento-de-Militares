using System;
using System.Collections.Generic;
using System.Data;
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

        public bool AdicionaUsuario(DTOUsuario dto)
        {
            string sql = $@"INSERT INTO usuario VALUES (DEFAULT
                                                     , '{dto.Nome}'
                                                     , '{dto.Senha}'
                                                     , '{dto.Tipo}'
                                                );";

            return My.ExecuteNonQuery(sql);
        }

        public bool EditaUsuario(DTOUsuario dto)
        {
            string sql = $@"UPDATE usuario
                               SET nome = '{dto.Nome}'
                                 , senha = '{dto.Senha}'
                                 , tipo = {dto.Tipo}
                               WHERE id = {dto.Id};";

            return My.ExecuteNonQuery(sql);
        }

        public bool DeletaUsuario(string id)
        {
            string sql = $"DELETE FROM usuario WHERE id = {id};";

            return My.ExecuteNonQuery(sql);
        }

        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT id, nome, tipo FROM usuario;";

            dt = My.GetDataTable(sql);

            My.FechaConexao();
            return dt;
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

        public DTOUsuario GetDTO(string user, string pass)
        {
            DTOUsuario dto = new DTOUsuario();

            if (UsuarioValido(user, pass))
            {
                string sql = $@"SELECT *
                               FROM usuario
                               WHERE nome = '{user}'
                                 AND senha = '{pass}';";

                My.ExecuteReader(sql);

                if (My.HasRows())
                {
                    My.ReadNextRecord();

                    dto.Id = My.GetInt("id");
                    dto.Nome = My.GetString("nome");
                    dto.Tipo = My.GetInt("tipo");
                    dto.Senha = My.GetString("senha");
                }

                My.FechaConexao();
            }
            else
            {
                dto = null;
            }

            return dto;
        }

        public DTOUsuario GetDTO(string id)
        {
            DTOUsuario dto = new DTOUsuario();

            string sql = $@"SELECT *
                               FROM usuario
                               WHERE id = '{id}';";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                My.ReadNextRecord();

                dto.Id = My.GetInt("id");
                dto.Nome = My.GetString("nome");
                dto.Tipo = My.GetInt("tipo");
                dto.Senha = My.GetString("senha");
            }

            My.FechaConexao();

            return dto;
        }
    }
}
