using System;
using System.Globalization;

namespace Primeiro
{
    //Classe para validar vetor com Estruturda de Dados Valor /Struct
    class Vetor_Struct
    {
        //Método Main
        static void Main(string[] args)
        {
            Console.Write("Digite o nº de Posições que o vetor terá: ");
            int n = int.Parse(Console.ReadLine() );

            double[] vetor = new double[n]; //Declarando o vetor e o tamanho que irá ter atraves do parâmetro n

            double soma = 0;

            //Estrutura fora para percorrer e popular o vetor e contar os valores do vetor
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite a {0}ª altura: ", i + 1);
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                soma += vetor[i];
            }

            Console.WriteLine("A soma das alturas é {0}", soma);
            Console.WriteLine("A média das alturas é {0}", (soma / n).ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}
