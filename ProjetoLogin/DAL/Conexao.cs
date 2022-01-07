
using System.Data.SqlClient;


namespace ProjetoLogin.DAL
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        public Conexao ()  // Construtor banco de dados
        {
            con.ConnectionString = @"Data Source=KEN\SQLEXPRESS;Initial Catalog=ProjetoLogin;Integrated Security=True";
        }

        public SqlConnection Conectar() 
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
