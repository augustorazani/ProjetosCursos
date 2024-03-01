using System.Globalization;

namespace ControleDeEstoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) //void não retorna valor / quando inciar variavel como PARAMETRO em uma funcao, sempre utilizar letra minuscula
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public void AdicionarValor (double taxa)
        {
            Preco += Preco * (taxa / 100);
        }
        public override string ToString() //override (sobreposicao) explicado no capitulo de heranca
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}