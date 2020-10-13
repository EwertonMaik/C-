using System;

namespace Primeiro
{
    //Classe para testar If Ternario
    class IF_Ternario
    {
        //Método Main
        static void Main(string[] args)
        {
            //Entrada de um Preço
            Console.Write("Digite um Preço : ");
            double preco = double.Parse(Console.ReadLine() );

            //Usando um IF Ternário
            // A variável desconto irá receber preco * 10% se preco for < 30 (Verdadeiro), , se for (Falso), receberá preco * 5%
            double desconto = (preco < 30.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine("Desconto : " + desconto);

            //Com a estrutura IF Ternário se poupa de escrever bem menos linhas

            //Usando IF Else
            if (preco < 30.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine("Desconto : " + desconto);
        }
    }
}