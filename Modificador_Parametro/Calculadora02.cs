using System;

namespace Primeiro.Modificador_Parametro
{
    //Classe para mostrar o segundo Exemplo sem a utilização de um modificador de parãmetro
    class Calculadora02
    {
        static void Main(string[] args)
        {
            //Chamando a Função para calcular n números
            //Pode-se passa n números, porém é necessário instânciar o vetor dentro do parametro da função
            int a = Calculadora02.Soma(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } );
            Console.WriteLine(a);
            //Na classe Calculadora03 é apresentado um alternativa melhor usando PARAMS
        }

        //Criando Método Public e static que podem ser chamado dentro do método main, nesta ou outra classe
        //Aqui é utilizado em vez de varios parâmetros, é passado um VETOR
        public static int Soma(int[] n)
        {
            int soma = 0;
            for (int i = 0; i < n.Length; i++) //Usa a função Length para pegar o tamanho do vetor
            {
                soma += n[i];
            }
            return soma;
        }
    }
}