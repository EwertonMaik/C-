using System;
using System.Collections.Generic;

namespace ExpressoesLambdaDelegatesLINQ.Predicate
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma Lista do Tipo Produto
            List<Produto> list = new List<Produto>();

            //Adicionando valores a lista
            list.Add(new Produto ("TV", 900.00) );
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.00));
            list.Add(new Produto("HD Externo", 80.00));
            list.Add(new Produto("CD / DVD RW", 15.00));

            Console.WriteLine("Removendo todos valores da Lista com RemoveAll - Usando Expressão Predicado");
            //Removendo todos valores da Lista com RemoveAll - Usando Expressão Predicado
            list.RemoveAll(p => p.Preco >= 100.0); //Remove todos os valores que atende a expressão

            //Imprimindo Valores
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }

            //***********************************
            Console.WriteLine("Removendo produtos, baseado em um expressão chamada por uma função");
            //Removendo produtos, baseado em um expressão chamada por uma função
            list.RemoveAll(ProdutoEx);

            //Imprimindo Valores
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        //Método para retornar o Produto que é igual a 15.00
        public static bool ProdutoEx(Produto prod)
        {
            return prod.Preco == 15.00;
        }
    }
}