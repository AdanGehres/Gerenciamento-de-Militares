using System;
using System.Collections.Generic;
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

        public ComboBox CBoxNomeMilitares(ComboBox cBox)
        {
            string sql = $@"SELECT nome FROM MILITAR";

            My.ExecuteReader(sql);

            if (My.HasRows())
            {
                while (My.ReadNextRecord())
                {
                    cBox.Items.Add(My.GetString("nome"));
                }
            }
            return cBox;
        }
    }
}
