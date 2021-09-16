using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_dados.DAL
{
    public class LoginDalComandos
    {
        public bool tem = false;
        public string mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        Conexao con = new Conexao();
        MySqlDataReader dr;
        public bool verificarLogin(string nome, string telefone)
        {
            //comando sql consulta id
            cmd.CommandText = "select * from pessoas where nome = @nome and telefone = @telefone";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (MySqlException)
            {
                this.mensagem = "Erro com banco de dados.";
            }
            return tem;
        }
        public string cadastrar(string nome, string telefone, string comtelefone)
        {
            tem = false;
            //comandos para inserir
            if (telefone.Equals(comtelefone))
            {
                cmd.CommandText = "insert into pessoas (nome, telefone) values (@a, @b);";
                cmd.Parameters.AddWithValue("@a", nome);
                cmd.Parameters.AddWithValue("@b", telefone);
                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconetar();
                    this.mensagem = "cadastrado com sucesso!";
                    tem = true;
                }
                catch (MySqlException e)
                {
                    this.mensagem = "erro com banco de dados." + e;
                }
            }
            else
            {
                this.mensagem = "Senha não correspondem";
            }
            return mensagem;
        }
    }
}
