using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class MySQL
    {

        //MySqlConnection 
        private MySqlConnection Connection;

        private MySqlCommand Command;

        /// <summary>
        /// Dados Resultantes
        /// </summary>
        private MySqlDataReader Reader { get; set; }

        public MySQL()
        {
            string ip = "127.0.0.1";
            string dBase = "militar";
            string user = "imed";
            string pass = "imed10741961";

            string connString = $@"server={ip};database={dBase};Uid={user};Pwd={pass}";
            Connection = new MySqlConnection(connString);
        }

        private bool AbreConexao()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um erro ao abrir a conexão:\n" + e);
                return false;
            }
        }

        public void FechaConexao()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um erro ao fechar a conexão:\n" + e);
            }
        }

        private void PreparaMySQL(string sql)
        {
            AbreConexao();
            CreateCommand();

            Command.CommandText = sql;
        }

        private void CreateCommand()
        {
            try
            {
                Command = new MySqlCommand();
                Command = Connection.CreateCommand();
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }
        }

        public bool ExecuteNonQuery(string sql)
        {
            bool ret = true;
            PreparaMySQL(sql);

            try
            {
                this.Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                ret = false;
                throw (new Exception(e.Message));
            }

            FechaConexao();
            return ret;
        }

        #region Métodos para o Reader

        public bool ExecuteReader(string sql)
        {
            PreparaMySQL(sql);

            try
            {
                Reader = null;
                Reader = Command.ExecuteReader();
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }

            return HasRows();
        }

        public bool HasRows()
        {
            bool auxReturn = false;
            if (this.Reader != null)
            {
                auxReturn = this.Reader.HasRows;
            }
            return auxReturn;
        }

        public bool ReadNextRecord()
        {
            bool auxReturn = false;
            if (this.Reader != null)
            {
                auxReturn = this.Reader.Read();
            }
            return auxReturn;
        }

        /// <summary>
        /// Retorna um inteiro
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public int GetInt(string column)
        {
            try
            {
                return Convert.ToInt32(this.Reader[column]);
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Retorna uma string
        /// </summary>
        /// <param name="column"></param>
        /// <returns></returns>
        public string GetString(string column)
        {
            try
            {
                return Convert.ToString(this.Reader[column]);
            }
            catch
            {
                return String.Empty;
            }
        }

        #endregion

        public DataTable GetDataTable(string sql)
        {
            PreparaMySQL(sql);

            DataTable retData = new DataTable();
            try
            {
                MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Command);

                DataAdapter.Fill(retData);
            }
            catch (Exception e)
            {
                throw (new Exception(e.Message));
            }

            FechaConexao();

            return retData;
        }
    }
}
