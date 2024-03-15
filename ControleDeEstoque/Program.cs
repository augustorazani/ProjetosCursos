using ControleDeEstoque;
using System;
using System.Globalization;

namespace ControleDeEstoquePOO_Encapsulamento
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco, quantidade); //instanciando o objeto Produto após obter os valores
                                                              //digitados pelo usuário

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); //operacao capaz de receber valor de entrada (parametro), e adiciona valor ao dado armazenado na caixa "p"

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite os dados de outro produto na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            p.Nome = vet[0];
            p.Preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
            p.Quantidade = int.Parse(vet[2]);

            Console.WriteLine();
            Console.Write("Agora digite a porcentagem aplicada sobre o valor total do produto: ");
            double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarValor(taxa);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine();
        }
    }
}