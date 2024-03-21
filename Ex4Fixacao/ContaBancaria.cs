using System.Globalization;

namespace Ex4Fixacao
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria() { }
        public ContaBancaria(int numeroConta, string nomeTitular, double saldo )
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }


        public void DepositarSaldo (double saldo)
        {
            Saldo += saldo;
        }
        public override string ToString()
        {
            return "Conta " +
                NumeroConta +
                ", Titular: " +
                NomeTitular +
                ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
