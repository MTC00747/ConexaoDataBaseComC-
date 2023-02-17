using System.Data.SqlClient;
namespace ProjetoBDSA3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(

                "User Id=IdDoUser;Password=SenhaDoUsuario" +
                "Server=localhost\\SQLEXPRESS;" +
                "Database=projetoclientes;" +
                "Trusted_Connection=false;"


            );

            using (SqlConnection conexao = new SqlConnection(builder.ConnectionString))
            {
                string sql = "Select * from clientes";

                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    conexao.Open();
                }
            }
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine("Erro : " + ex.ToString());
        }
    }


}
