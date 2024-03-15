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
            {
                try
                {
                    connection.Open();

                    Produto produto = new Produto();

                    Console.WriteLine("Entre com os dados do produto: ");
                    Console.Write("Id do produto: ");
                    produto.IdProduto = int.Parse(Console.ReadLine());

                    Console.Write("Nome: ");
                    produto.Nome = Console.ReadLine();

                    Console.Write("Quantidade: ");
                    produto.Quantidade = int.Parse(Console.ReadLine());

                    Console.Write("Preco: ");
                    produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    // Atualizar o comando SQL para incluir todos os campos necessários
                    SqlCommand enviarProduto = connection.CreateCommand();
                    enviarProduto.CommandText = "INSERT INTO Produto(idProduto, nome, quantidade, preco)" +
                        "VALUES(@IdProduto, @Nome, @Quantidade, @Preco)";
                    enviarProduto.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                    enviarProduto.Parameters.AddWithValue("@Nome", produto.Nome);
                    enviarProduto.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    enviarProduto.Parameters.AddWithValue("@Preco", produto.Preco);

                    // Executar o comando SQL para inserir o produto na tabela Produto
                    enviarProduto.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
                }
                finally { connection.Close(); }
            }
        }
    }
}