using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel
{
    class Conexao
    {
        string dadosConexao = "SERVER=localhost; DATABASE=db_hotel; UID=root; PWD=; PORT=;";
        public MySqlConnection MySqlConnection = null;
        public void AbrirCon()
        {
            try
            {
                MySqlConnection = new MySqlConnection(dadosConexao);
                MySqlConnection.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void FecharCon()
        {
            try
            {
                MySqlConnection = new MySqlConnection(dadosConexao);
                MySqlConnection.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
