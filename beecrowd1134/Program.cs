﻿using System;

namespace beecrowd1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int comb = int.Parse(Console.ReadLine());

            while (comb != 4)
            {
                if (comb == 1)
                {
                    alcool = alcool + 1;
                }
                else if (comb == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (comb == 3)
                {
                    diesel = diesel + 1;
                }
                comb = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}