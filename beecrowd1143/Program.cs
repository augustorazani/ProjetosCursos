using System;

namespace Beecrowd1143
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int quadrado = (int)Math.Pow(i, 2);
                int cubo = (int)Math.Pow(i, 3);
                Console.WriteLine($"{i} {quadrado} {cubo}");
            }
        }
    }
}