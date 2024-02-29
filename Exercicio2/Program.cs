using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x %2 != 0){
                Console.WriteLine("IMPAR");
            }
            
            else
            {
                Console.WriteLine("PAR");
            }
            Console.ReadLine();
        }
    }
}
