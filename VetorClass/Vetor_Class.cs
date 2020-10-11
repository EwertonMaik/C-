using System;
using System.Globalization;

namespace Primeiro
{
    //Classe Vetor_Class para usar vetor de um Classe Product
    class Vetor_Class
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nº de Posições que o vetor terá:");
            int n = int.Parse(Console.ReadLine() );

            //Declarando e instânciando um vetor tipo Classe
            Product[] vetproduct = new Product[n]; // Quantidade no valor do parâmetro

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome Produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine() );
                vetproduct[i] = new Product {Nome = nome, Price = price };
                /*
                 A atribuição pode ser da seguinte forma também
                 vetproduct[i].Price = price;
                 vetproduct[i].Nome  = nome;
                 */
                soma += vetproduct[i].Price;
                
            }

            //Imprimindo valores
            Console.WriteLine("Preço Médio é {0}", (soma / n).ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}