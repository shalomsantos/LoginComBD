using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_dados.DAL
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = @"server=localhost;user id=root;database=cadastro; pwd=Skate1234";
        }

        public MySqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconetar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
