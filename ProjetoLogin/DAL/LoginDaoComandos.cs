
using System.Data.SqlClient;


namespace ProjetoLogin.DAL
{
    internal class LoginDaoComandos
    {
        public bool Tem { get; set; } = false;
        public string Mensagem { get; set; } = ""; // vazia == okay 
        
        SqlCommand cmd = new SqlCommand();

        Conexao con = new Conexao();
        SqlDataReader dr;
        public bool VerificarLogin(string login, string senha)
        {
            //Comando SQL verifica no banco
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login); // Add informacao para o select
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader(); // pegando e guardando info (login / senha)
                if(dr.HasRows) // se foi encontrado login e senha
                {
                    Tem  = true;
                }
                con.Desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                Mensagem = "Erro com o banco de dados!";
            }
            return Tem;
        }

        public string Cadastrar(string email, string senha, string confirmarSenha)
        {
            Tem = false;
            //Comandos para inserir
            if (senha.Equals(confirmarSenha))
            {
                cmd.CommandText = "INSERT INTO logins VALUES (@email, @senha);";
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);

                try
                {
                    cmd.Connection=con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.Desconectar();
                    Mensagem = "Cadastrado com sucesso!";
                    Tem = true;
                }
                catch (SqlException)
                {
                    Mensagem = "Erro com o banco de dados ";   
                }
            }
            else
            {
                Mensagem = "Senhas não correpondem!";
            }
            return Mensagem;
        }
    }
}
