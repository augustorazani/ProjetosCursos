using System;

namespace uri1153
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }

            Console.WriteLine(fat);
            Console.ReadLine();
        }
    }
}