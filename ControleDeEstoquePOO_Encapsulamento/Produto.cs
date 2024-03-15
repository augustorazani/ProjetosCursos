using System.Globalization;
using System.Security.AccessControl;

namespace ControleDeEstoque
{
    internal class Produto
    {
        private string _nome;
        public double Preco {  get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade) //construtor
        {
            _nome = nome; //Nome (atributo do objeto Produto) recebe "nome" (parâmetro recebido no método)
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set { //ao utilizar SET, a palavra VALUE substitui o valor recebido como parâmetro no método SET
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) //verifica se o nome é diferente de nulo e o tamanho da string é maior que 1 caractere
            {
                _nome = nome;
            }
        }

        public Produto(string nome, double preco) //construtor utilizando SOBRECARGA com apenas dois parâmetros
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }
        public Produto()//cria construtor que permite o uso do método sem passar parâmetros no programa
        {
        }

        //this = permite referenciar um construtor dentro de outro constutor ( :this(nome, preco){ )
        */
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

        public void AdicionarValor(double taxa)
        {
            Preco += Preco * (taxa / 100);
        }

        public override string ToString() //override (sobreposicao) explicado no capitulo de heranca
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades , Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}