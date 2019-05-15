﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerênciamento_de_Militares.DataBase
{
    public class Militar
    {
        private MySQL My;

        public Militar()
        {
            My = new MySQL();
        }

        public bool AdicionaMilitar(string grad, string nome)
        {
            string sql = $@"INSERT INTO MILITAR (GRADUACAO, NOME)
                                         VALUES ('{grad}', '{nome}')";

            return My.ExecuteNonQuery(sql);
        }

        public int GetIdByName(string nome)
        {
            int id = 0;

            string sql = $@"SELECT id
                               FROM MILITAR
                               WHERE NOME = '{nome}'
                               ORDER BY id DESC
                               LIMIT 1;";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                My.ReadNextRecord();
                id = My.GetInt("id");
            }

            My.FechaConexao();
            return id;
        }

        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            string sql = "SELECT * FROM MILITAR;";

            dt = My.GetDataTable(sql);

            My.FechaConexao();

            return dt;
        }

        public bool ExcluiMilitar(string id)
        {
            string sql = $@"DELETE FROM MILITAR WHERE ID = {id};";

            return My.ExecuteNonQuery(sql);
        }

        public ComboBox CBoxNomeMilitares(ComboBox cBox)
        {
            //Adiciona item em branco no início
            cBox.Items.Add(string.Empty);

            string sql = $@"SELECT nome FROM MILITAR";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                while (My.ReadNextRecord())
                {
                    cBox.Items.Add(My.GetString("nome"));
                }
            }

            My.FechaConexao();
            return cBox;
        }
    }
}
