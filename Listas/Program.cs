using System;
using System.Collections.Generic;

namespace Listas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria"); //.Add adiciona elementos na lista (ultima posicao)
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco"); //.Insert insere elementos na lista em uma posicao especificada

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            String s1 = list.Find(x => x[0] == 'A'); //busca primeiro elmento com o caractere "A" na posição zero (primeira letra)
            Console.WriteLine("First 'A': " + s1);   //utiliza expressao lambda

            String s2 = list.FindLast(x => x[0] == 'A');  //busca ultimo elmento com o caractere "A" na posição zero (primeira letra)
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A'); //busca a posicao do primeiro elemento com o caractere "A" na posição zero (primeira letra)
            Console.WriteLine("First position 'A':" + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); //busca a posicao do ultimo elemento com o caractere "A" na posição zero (primeira letra)
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5); //busca todos elementos na lista que possuam 5 caracteres
            Console.WriteLine("---------------------");
            foreach (string obj in list2) //laco para exibir cada elemento encontrado na list
            {
                Console.WriteLine(obj);
            }
            list.Remove("Alex"); //.Remove remove um elemento que atender o parametro passado
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M'); //remove todos os elementos na lista com o caractere "M" na posicao zero (primeira letra)
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}