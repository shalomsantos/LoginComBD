using Banco_de_dados.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_de_dados.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string nome, string telefone)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            tem = loginDal.verificarLogin(nome, telefone);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return tem;
        }
        public string cadastrar(string nome, string telefone, string comtelefone)
        {
            LoginDalComandos loginDal = new LoginDalComandos();
            this.mensagem = loginDal.cadastrar(nome, telefone, comtelefone);
            if (loginDal.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
