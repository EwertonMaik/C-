using System;
using System.Collections.Generic;

namespace ExpressoesLambdaDelegatesLINQ.MetodoSortAndComparionT.Versao04
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

            //Delegate Comparison, recebe os argumentos de uma função Lambda + expressão
            Comparison<Produto> compProd = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper() );

            //Método que ordena a lista por padrão usando Comparer
            //Recebe a referência do Objeto Função CompararProdutos implementado logo abaixo
            list.Sort(compProd); //Recebe referencia por argumento

            //list.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper())); Pode ser passado os argumentos e expressão diretamente ao Sort()

            //Imprimi os valores da Lista
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}