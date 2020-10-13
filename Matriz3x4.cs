using System;

namespace Primeiro
{
    //Classe para Testar uma matriz 3 Linhas por 4 Colunas
    //Pesquisa um valor dentro da Matriz e Informa a Posição a Esquerda/Direita/Superior e Inferior
    class Matriz3x4
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando a Matriz e Informando seu Tamanho
            Console.WriteLine("Matriz 3 X 4");
            int[,] matriz = new int[3, 4];

            //Populando a Matriz com 2 estruturas FOR e salvando o valor com Split
            Console.WriteLine("Digite os valores da Matriz: ");
            for (int linha = 0; linha < 3; linha++) // Linhas
            {
                string[] vetstring = Console.ReadLine().Split(" "); //Quebra a String e salva cada posição no vetor

                for (int coluna = 0; coluna < 4; coluna++) // Colunas
                {
                    matriz[linha, coluna] = int.Parse(vetstring[coluna] );
                }
            }

            //Buscando valor para ser Pesquisado na Matriz
            Console.Write("Digite o Nº que será pesquisado na Matriz 3x4 : ");
            int x = int.Parse(Console.ReadLine() );

            for (int linha = 0; linha < 3; linha++) // Linhas
            {
                for (int coluna = 0; coluna < 4; coluna++) // Colunas
                {
                    if ( matriz[linha, coluna] == x ) // Verifica se o valor na posição linha / coluna é igual a X
                    {
                        if (coluna > 0) // Para trazer a posição da Esquerda
                        {
                            Console.WriteLine( "Esquerda : " + matriz[linha, coluna - 1] );
                        }
                        if (coluna < 4 - 1) // Para trazer a posição da Direita
                        {
                            Console.WriteLine("Direita : " + matriz[linha, coluna + 1] );
                        }
                        if (linha > 0) // Para trazer a posição Superior
                        {
                            Console.WriteLine("Superior : " + matriz[linha - 1, coluna] );
                        }
                        if (linha < 3 - 1) // Para trazer a posição Inferior
                        {
                            Console.WriteLine("Inferior : " + matriz[linha + 1, coluna]);
                        }
                    }
                }
            }
        }
    }
}