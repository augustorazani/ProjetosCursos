using System;

namespace beecrowd1046
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            string[] horas = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(horas[0]);
            horaFinal = int.Parse(horas[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}