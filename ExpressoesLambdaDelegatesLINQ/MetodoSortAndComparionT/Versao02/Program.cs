using System;
using System.Collections.Generic;

namespace ExpressoesLambdaDelegatesLINQ.MetodoSortAndComparionT.Versao02
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Lista de Produtos
            List<Produto> list = new List<Produto>();

            //Adicionado Valores a Lista
            list.Add(new Produto("TV", 900.00) );
            list.Add(new Produto("Notebook", 1200.00) );
            list.Add(new Produto("Tablet", 450.00) );

            //Método que ordena a lista por padrão usando Comparer
            //Recebe a referência do Objeto Função CompararProdutos implementado logo abaixo
            list.Sort(CompararProdutos); //Delegates - Referência a função com type-safe

            //Imprimi os valores da Lista
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        //Criado um Método para comparar Produtos, Usando Comparable da classe string
        //Sem ter que implementar a Interface IComparable na classe Produto
        static int CompararProdutos(Produto p1, Produto p2)
        {
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper() );
        }
    }
}