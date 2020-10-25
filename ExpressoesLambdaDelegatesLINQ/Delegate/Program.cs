using System;

namespace ExpressoesLambdaDelegatesLINQ.Delegate
{
    //Classe Principal
    class Program
    {
        //Declarando um Delegate - Com apenas 2 parâmetros
        delegate double OperacaoNumerica(double a, double b);

        //Método Main
        static void Main(string[] args)
        {
            //Declarando variáveis
            double a = 10;
            double b = 12;

            //Chamando Métodos da Classe CalculoServico
            double r01 = CalculoServico.Mair(a, b);    // 2 Parâmetros
            double r02 = CalculoServico.Soma(a, b);    // 2 Parâmetros
            double r03 = CalculoServico.Quadrado(a);   // 1 Parâmetros

            Console.WriteLine($"Maio - {r01} / Soma - {r02} / Quadrado - {r03}");


            Console.WriteLine("*** Usando Declaração DELEGATE ***");
            //Delegate - Referência com Type Safe para um ou mais métodos
            //Instânciado Delegate
            OperacaoNumerica opeMaior = CalculoServico.Mair;
                opeMaior = new OperacaoNumerica(CalculoServico.Mair); //Sintaxe Alternativa
            OperacaoNumerica opeSoma = CalculoServico.Soma;
                opeSoma = new OperacaoNumerica(CalculoServico.Soma); //Sintaxe Alternativa
            //OperacaoNumerica opeQuad = CalculoServico.Quadrado; // Isso dá erro e não é permitido, pois a assinatura desta função tem 1 parâmetro

            //Executando Método com Delegate
            r01 = opeMaior(a, b);
            r02 = opeSoma(a, b);

            Console.WriteLine($"Maio - {r01} / Soma - {r02}");
        }
    }
}