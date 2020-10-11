using System;

namespace Primeiro
{
    //Classe para testar Foreach
    class EstruturaForeach
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando e atribuido um vetor para ser percorrido por um for comum e um foreach
            string[] vetor = new string[] { "MARIA", "CARLOS", "PEDRO", "JOAO" };

            //Imprimindo com FOR convencional
            Console.WriteLine("Estrutura FOR");
            for (int i = 0; i < vetor.Length; i++) // Percorre de 0 até o tamanho do vetor com Length
            {
                Console.WriteLine("Vetor Posição {0} é = {1}",i, vetor[i]);
            }

            //Imprimindo com FOREACH - Trabalha especificamente com Listas
            Console.WriteLine("Estrutura FOREACH");
            foreach (string obj in vetor)
            {
                Console.WriteLine("Vetor Posição {0} ",obj);
            }
        }
    }
}