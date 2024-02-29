using System;
using System.Globalization;

namespace exercicio_2._2_prova
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = (Math.Pow(b, 2)) - (4 * a * c);

            double R1 = (-b + (Math.Sqrt(delta))) / (2 * a);
            double R2 = (-b - (Math.Sqrt(delta))) / (2 * a);

            if (a != 0 && delta > 0)
            {
                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
                Console.Read();
            }
        }
    }
}