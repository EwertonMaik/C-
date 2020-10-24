using System;
using System.Collections.Generic;

namespace ExpressoesLambdaDelegatesLINQ.MetodoSortAndComparionT.Versao01
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
            //Funciona apenas se a classe do Tipo da Lista implementa a interface Icomparable
            list.Sort();

            //Imprimi os valores da Lista
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}