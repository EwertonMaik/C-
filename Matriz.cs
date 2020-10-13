using System;

namespace Primeiro
{
    //Classe para utilizar Matrizes
    class Matriz
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarado e Intãnciado uma Matriz Bidimencional
            double[,] matriz = new double[2,3]; //2 Linhas e 3 Colunas

            //Mostra o tamanho da Matriz
            Console.WriteLine("Tamanho da Matriz : " + matriz.Length);

            //Mostra a quantidade de Linhas da Matriz
            Console.WriteLine("Quantidade Linhas Matriz : " + matriz.Rank);

            //Mostra a Dimensão da Matiz 
            Console.WriteLine("Dimensão da Matriz : " + matriz.GetLength(0) );
        }
    }
}