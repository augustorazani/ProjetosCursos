using System;
using System.Globalization;

namespace Beecrowd1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double divisao = 0.0;
            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);

                if (b != 0)
                {
                    divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
