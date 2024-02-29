using System;
using System.Globalization;


namespace exercicio_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio, area;
            
            raio = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (float)(3.14159 * Math.Pow(raio, 2));
   
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
