using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoesLambdaDelegatesLINQ.Linq.Caso01
{
    //Classe Principal para Testar Linq
    class LinqWithWhereAndSelect
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando um vetor que sera a fonte de dados utilizada
            int[] numeros = new int[] { 1,2,3,4,5,6,7,8,9,10 };

            //Definindo uma Expressão Consulta
            //Seleciona no Vetor, apenas os nºs pares e os multiplica por 10
            //Retorno do resultado é uma Lista Genérica da Interface IEnumerable
            IEnumerable<int> resultado = numeros.Where(x => x % 2 == 0).Select(x => x * 10);

            //Executando a Consulta e imprimindo valores
            foreach (int obj in resultado)
            {
                Console.WriteLine(obj);
            }
        }
    }
}