using System;
using System.Globalization;
using System.Data.SqlClient;

namespace ObjetosComBancoDeDados
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            string connectionString = "Data Source=RAZANI\\SQL2022;User ID=admin;Password=1234;Encrypt=false;";

            using (SqlConnection connection = new SqlConnection(connectionString))
                try
                {
                    connection.Open();

                    Produto produto = new Produto();

                    Console.WriteLine("Entre com os dados do produto: ");
                    Console.Write("Id do produto: ");
                    produto.IdProduto = int.Parse(Console.ReadLine());
                    SqlCommand enviarIdProduto = connection.CreateCommand();

                    enviarIdProduto.CommandText = "INSERT INTO Produto(idProduto) VALUES(@IdProduto)";
                    enviarIdProduto.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                    // Executar o comando SQL para inserir o idProduto na tabela Produto
                    enviarIdProduto.ExecuteNonQuery();

                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Preco: ");
                    produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro: " + ex.Message);
                }
                finally { connection.Close(); }
        }
    }
}