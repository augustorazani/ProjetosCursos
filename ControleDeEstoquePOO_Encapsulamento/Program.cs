using ControleDeEstoque;
using System;
using System.Globalization;

namespace ControleDeEstoquePOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T"; //conforme o if programado na propriedade SET da classe Produto,
                          //o atributo Nome permanecerá TV pois foi instanciado dessa forma na linha 11 (para setar, é necessário value.Length > 1)

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p);
            Console.ReadLine();

        }
    }
}