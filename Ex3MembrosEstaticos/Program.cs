using System;
using System.Globalization;

namespace Ex3MembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double result = ConversorDeMoeda.CalcularReais(cotacao, qtd);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}