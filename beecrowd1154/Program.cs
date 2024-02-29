using System;
using System.Globalization;

namespace beecrowd1154
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int qtdIdade = 0;
            int cont = 0;

            while (idade >= 0)
            {
                qtdIdade = qtdIdade + idade;
                cont = cont + 1;
                idade = int.Parse(Console.ReadLine());
            }

            double media = (double)qtdIdade / cont;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}