using System;

namespace Primeiro
{
    //Classa para Testar Inferencia de Tipo de Dados
    class InferenciaTipoDados
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando variável e especificando o seu Tipo
            int n1 = 10; // Variável do tipo INT

            //Declarando por Inferência
            var n2 = 10; // Por inferência o C# identificad que 10 é um nº INT 
            var n3 = 10.0; // ... DOUBLE
            var n4 = "Sebastião"; // ... STRING
            var n5 = 'M'; // ... CHAR
            var n6 = true; // ... BOOLEAN


            Console.WriteLine("{0} {1} {2} {3} {4} {5} ",n1, n2, n3.ToString("F2"), n4, n5, n6);
        }
    }
}