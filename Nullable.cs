using System;

namespace Primeiro
{
    //Classe para validar funções de Nullable
    class Nullable
    {
        //Método Main
        static void Main(string[] args)
        {
            //Tipos primitivos, Valor / Struct não aceita null
            //double x = null; // Obtem erro, não aceita

            Nullable<double> x = null; //Definido que o tipo double aceita null agora
            double? y = null; // Pode ser escrito dessa forma também com a (?)
            x = 10.00;

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("Resultado : " + x.GetValueOrDefault() ); // Método que obtem o valor de x ou o valor padrão caso não exista valor
            Console.WriteLine("Resultado : " + y.GetValueOrDefault());

            Console.WriteLine("Resultado : " + x.HasValue); //Função para retornar se existe ou não um valor na variável
            Console.WriteLine("Resultado : " + y.HasValue);

            //Usando HasValue para verificar se existe valor e imprime o valor com Value
            if (x.HasValue)
            {
                Console.WriteLine("X Tem valor: " + x.Value);
            }
            else
            {
                Console.WriteLine("X é Null");
            }

            if (y.HasValue)
            {
                Console.WriteLine("Y Tem valor : " + y.Value);
            }
            else
            {
                Console.WriteLine("Y é Null");
            }

            //Usando Operador de Coalescência nula
            //Se o valor for Null é atribuido outro valor
            double? a = null; // Tipo que aceita Nullable

            double b; // Não aceita Nullable
            b = a ?? 10.00; // Usando o operador ??, se a for null, é atribuido o valor 10.00

            Console.WriteLine("Valor de b = " + b);
        }
    }
}
