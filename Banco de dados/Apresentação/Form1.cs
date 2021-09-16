using Banco_de_dados.Apresentação;
using Banco_de_dados.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//PROJETO DE ESTUDO DE BANCO DE DADOS.

namespace Banco_de_dados
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        //BOTÃO SAIR DA TELA LOGIN
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //EVENTO CHAMA FORM CADASTRE-SE
        private void btnCadastreSe_Click(object sender, EventArgs e)
        {
            formCadastreSe cad = new formCadastreSe();
            cad.Show();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            control.acessar(txbNome.Text, txbTelefone.Text);
            if (control.mensagem.Equals(""))
            {
                if (control.tem)
                {
                    MessageBox.Show("Logado com sucesso.", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formUsuario bemvindo = new formUsuario();
                    bemvindo.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}
