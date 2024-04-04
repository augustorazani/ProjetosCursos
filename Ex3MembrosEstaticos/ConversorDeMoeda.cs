namespace Ex3MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        public static double iof = 6.0;

        public static double CalcularReais(double cotacao, double qtd) //método para converter junto com a taxa
        {
            double total = cotacao * qtd;
            return total + total * (iof/100.0);
        }
    }
}
