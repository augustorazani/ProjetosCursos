using System;

namespace Exercicio1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NAO NEGATIVO");
            }
            Console.ReadLine();
        }
    }
}