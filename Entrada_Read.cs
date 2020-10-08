using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Entrada_Read // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Entrada de Dados com Console.ReadLine(); Valores digitados são salvos nas variáveis
            Console.WriteLine("Digite");
            string   a = Console.ReadLine();
            string   x = Console.ReadLine();
            string   y = Console.ReadLine();
            string   z = Console.ReadLine();

            //Função de String Split - quebra a String onde tem espaço e armazena em cada pocisão do vetor

            Console.WriteLine(" Entre com 3 valores: ");
            string[]  vetor = Console.ReadLine().Split(' '); //Lendo e já aplicando o split e salvando em cada posição do vetor
            string a1 = vetor[0];
            string b1 = vetor[1];
            string c1 = vetor[2];
            
            //Imprimindo variáveis
            Console.WriteLine("Você digitou : ");
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(c1);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
