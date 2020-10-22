using System;

namespace WorkingGenerics.Caso03ComGenerics
{
    //Classe Principal
    class Program
    {
        //Método Principal
        static void Main(string[] args)
        {
            //Declarando variável da Classe com Generic e Type Safety
            //Posso declarar a variável de definir qual será seu tipo
            ServicoImpressao<int> simp = new ServicoImpressao<int>();
            //ServicoImpressao<string> simp2 = new ServicoImpressao<string>();

            Console.Write("Quantos valores deseja digitar? : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)//Para controlar a quantidade que será digitada
            {
                Console.Write($"Valor {i} : ");
                int x = int.Parse(Console.ReadLine() );
                simp.AdicionarValores(x);
            }

            //Imprimindo Valores
            simp.Imprimir();
            Console.WriteLine("Primeiro Valor : " + simp.PrimeiroValor() );
        }
    }
}