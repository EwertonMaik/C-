using System;
using System.Collections.Generic;
using System.Globalization;

namespace WorkingGenerics.Case04MetodoGenericAndIComparable
{
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma lista do Tipo Produto
            List<Produto> list = new List<Produto>();

            Console.Write("Digite Nº Produtos : ");
            int n = int.Parse(Console.ReadLine() );

            Console.WriteLine("Digite Nome Produto, Preço");
            for (int i = 0; i < n; i++) //Percorre a quantidade informada para digitar e salvar os valores na lista
            {
                string[] vetor = Console.ReadLine().Split(",");
                double preco = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                list.Add(new Produto(vetor[0], preco) );
            }

            CalculoServico cs = new CalculoServico();
            Produto prod = cs.Maximo(list); //Chama o método para buscar o valor máximo da lista

            Console.WriteLine("Item Máximo da Lista : " + prod);

        }
    }
}