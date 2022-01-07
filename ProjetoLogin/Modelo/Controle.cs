using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool Tem { get; set; }

        public string Mensagem = "";
        
        public bool Acesso (string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            Tem = loginDao.VerificarLogin(login, senha);
            if(!loginDao.Mensagem.Equals("")) // Mensagem preenchida com string de erro
            {
                this.Mensagem = loginDao.Mensagem;
            }
            return Tem;
        }
        
        public string Cadastrar(string email, string senha, string confirmarSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            Mensagem = loginDao.Cadastrar(email, senha, confirmarSenha);
            if(loginDao.Tem) // mensagem de sucesso no cadastro
            {

            }
            return Mensagem;
        }
    }
}
