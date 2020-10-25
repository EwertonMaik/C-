using System;

namespace ExpressoesLambdaDelegatesLINQ.MulticastDelegate
{
    //Classe Usada para Testar Multcast Delegate, ambos 2 parâmetros
    class Calculo
    {
        //Método Maio
        public static void Maior(double a, double b)
        {
            double maior = (a > b) ? a : b;
            Console.WriteLine("Maior = " + maior);
        }

        //Método Soma
        public static void Soma(double a, double b)
        {
            double soma = a + b;
            Console.WriteLine("Soma = " + soma);
        }
    }
}