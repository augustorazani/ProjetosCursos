namespace ObjetosComBancoDeDados
{
    internal class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto()
        {
        }
        public Produto (int idProduto, string nome, int quantidade, double preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }
    }
}
