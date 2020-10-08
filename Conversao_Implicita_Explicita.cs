using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Conversao_Implicita_Explicita // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Coversão Implicita entre Tipos - Double = 8 Bytes e o Float 4 Bytes
            float  var_float   = 4.98F;
            double var_double3 = var_float; // O tipo Double é maior e aceita conversão implicita de um tipo menor, como tipo Float
            Console.WriteLine(var_double3);

            //Conversão Explicita isso pode gerar peda de dados
            //Double = 8 Bytes e o Float 4 Bytes, para jogar o valor de uma var Double em uma var Float, é preciso realizar um CAST
            float var_float2;
            double var_double4 = 8.57;
            int var_int;

            var_float2 = (float)var_double4; //Variável Float tamanho 4 bits recebendo o valor de uma  variável Double 8 bits, via CAST
            Console.WriteLine(var_float2);

            var_int = (int)var_double4; //Variável Int tamanho 4 bits que não tem por sinal valor quebrado, recebendo variável Double 8 bits, via CAST
            Console.WriteLine(var_int);

            //Uma variável Double recebendo o valor de uma divisão entre inteiros, o resultado é um INTEIRO
            var_int = 100;
            double resultado = var_int / 3; //Mesmo a var resultado sendo Double, a divisão entre var_int / 3, retorna um inteiro
            Console.WriteLine(resultado);

            //Uma variável Double recebendo o valor de uma divisão entre inteiros com um CAST, se a divisão tiver valores quebrados,
            //Devido ao CAST o valor correspondente será salvo sem perda de dados 
            resultado = (double)var_int / 3;
            Console.WriteLine(resultado);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
