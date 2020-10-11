using System;

namespace Primeiro.Modificador_Parametro
{
    //Classe para mostrar o primeiro Exemplo sem a utilização de um modificador de parãmetro
    class Calculadora01
    {
        //Método Main
        static void Main(string[] args)
        {
            //Chamando Método
            int a = Calculadora01.Soma(1, 2); // Calcula nº com 2 parâmetros
            int b = Calculadora01.Soma(1, 2, 3); // Calcula nº com 3 parâmetros
            Console.WriteLine(a + " " + b);
            //Na classe Calculadora02 é apresentado um alternativa melhor
        }

        //Criando Método Public e static que podem ser chamado dentro do método main, nesta ou outra classe
        public static int Soma(int p1, int p2) //Criado o método com 2 parâmetros de entrada
        {
            return p1 + p2;
        }

        //Se quiser o mesmo método aceitando + parâmetros, teria que criar manualmente mais métodos e parâmetros
        public static int Soma(int p1, int p2, int p3) //Criado o método com 2 parâmetros de entrada
        {
            return p1 + p2 + p3;
        }
    }
}