using System;
using System.Globalization;

namespace desafios
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            float preco1, preco2;

            String[] vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            qtd1 = int.Parse(vet[1]);
            preco1 = float.Parse(vet[2], CultureInfo.InvariantCulture);

            String[] vet2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet2[0]);
            qtd2 = int.Parse(vet2[1]);
            preco2 = float.Parse(vet2[2], CultureInfo.InvariantCulture);

            float soma = (preco1 * qtd1) + (preco2 * qtd2);
            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}