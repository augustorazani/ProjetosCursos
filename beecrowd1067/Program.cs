using System;

namespace beecrowd1067
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int cont = 1;
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Numero ímpar #{0}: {1}", cont, i);
                    cont++;
                }
            }
        }
    }
}