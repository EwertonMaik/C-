using System;

namespace Primeiro
{
    //Classe Matrizes
    class Matrizes
    {
        static void Main(string[] args)
        {
            //Digite valor de N
            Console.Write("Digite o Nº da Matriz N / N: ");
            int n = int.Parse(Console.ReadLine() );

            //Declarando a Matriz N / N
            int[,] mat = new int[n, n];

            //Populando a matriz dentro de um Estrutura For For e usando Split
            Console.WriteLine("Digite as Valores com espaço de cada Linha/Coluna : ");
            for (int l = 0; l < n; l++) // Percorre as Linhas da Matriz
            {
                string[] vvetor = Console.ReadLine().Split(" ");

                for (int c = 0; c < n; c++) // Percorre as Colunas da Matriz
                {
                    mat[l, c] = int.Parse(vvetor[c]); // pega os Valores do Vetor e adiciona na Matriz
                }
            }

            //Imprimindo Apenas a Linha Diagonal
            Console.WriteLine("Imprimindo a Linha Diagonal");
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + mat[i, i]);
            }

            //Imprimindo Quando Nº Negativos tem na Matriz
            Console.WriteLine("");
            int contador = 0;
            for (int l = 0; l < n; l++) // Percorre Linhas
            {
                for (int c = 0; c < n; c++) // Percorre Colunas
                {
                    if (mat[l, c] < 0) // Verifica se dentro da posição tem valor negativo e incrementa no contador
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine("Total Nº Negativos na Matriz : " + contador);

        }
    }
}