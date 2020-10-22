using System;

namespace WorkingGenerics.Caso02ComObject
{
    //Classe Principal
    class Program
    {
        //Método Principal
        static void Main(string[] args)
        {
            //Declarando variável
            ServicoImpressao simp = new ServicoImpressao();

            Console.Write("Quantos valores deseja digitar? : ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)//Para controlar a quantidade que será digitada
            {
                Console.Write($"Valor {i} : ");
                object x = Console.ReadLine(); //Irá aceitar Nºs e Strings
                simp.AdicionarValores(x);
            }

            //Imprimindo Valores
            simp.Imprimir();
            Console.WriteLine("Primeiro Valor : " + simp.PrimeiroValor() );
        }
    }
}
