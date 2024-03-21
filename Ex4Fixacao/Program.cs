using System;
using System.Globalization;

namespace Ex4Fixacao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
            classe conta
            atributos:
            NumeroConta = get private set
            NomeTitular = get set
            Saldo = pode ser zero e negativo, private get private set

            metodos:
            DepositarSaldo void double saldo
            SaqueSaldo void double saldo + $5,00/cada saque
            override ToString para obter os dados atuais da conta
            */

            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            conta.NomeTitular = Console.ReadLine();

            char deposita;
            do
            {
                Console.Write("Haverá depósito inicial (s/n)? ");
                deposita = char.Parse(Console.ReadLine());
                switch (deposita)
                {
                    case 's':
                        Console.WriteLine("Entre o valor de depósito inicial: ");
                        conta.DepositarSaldo(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        Console.WriteLine("Dados da conta:");
                        Console.WriteLine(conta);
                        break;

                    case 'n':
                        Console.WriteLine("Dados da conta:");
                        Console.WriteLine(conta);
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!!");
                        break;
                }
            }
            while (deposita != 's' && deposita != 'n');
            Console.ReadLine();
        }
    }
}