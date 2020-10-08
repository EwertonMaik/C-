using System;

namespace Primeiro
{
    class Variaveis
    {
        static void Main(string[] args)
        {    
            //Declaração de Váriaivies Locais
            sbyte  v_sbyte   = 126;         // até 127
            int    v_int     = 2147483647;  // até 2147483647
            byte   v_byte    = 255;         // até 255
            long   v_long    = 2147483648L;  //
            bool   v_bool    = true;         // aceita true ou false
            char   v_char    = 'M';          // aceita apenas um Caracter, Ex: 'M', 'F'
            char   v_char2   = '\u0041';     // outra forma de representar um valor caracter pelo seu código
            float  v_float   = 4.5F;
            double v_double  = 4.5;
            String v_string  = "Maria Green";
            Object v_object  = "João Brown";
            Object v_obj     = 4.5F;
            double v_double2 = 10.123456789;

            int v_int_m      = int.MinValue;  //Variáveil INT recebendo o Mínimo valor do Tipo INT
            Console.WriteLine(int.MaxValue);  //Imprimindo o valor máximo permitido no tipo de dados INT
            Console.WriteLine("Tipo Decimal - MIN {0} - MAX {1}", decimal.MinValue, decimal.MaxValue); //Imprimindo MIN e MAX do tipo Decimal
            Console.WriteLine("Tipo Double - MIN {0} - MAX {1}", double.MinValue, double.MaxValue); //Imprimindo MIN e MAX do tipo Double
            Console.WriteLine("Tipo Long - MIN {0} - MAX {1}", long.MinValue, long.MaxValue); //Imprimindo MIN e MAX do tipo Lon
            Console.WriteLine("Tipo sbyte - MIN {0} - MAX {1}", sbyte.MinValue, sbyte.MaxValue); //Imprimindo MIN e MAX do tipo sbyte
            Console.WriteLine("Tipo byte - MIN {0} - MAX {1}", byte.MinValue, byte.MaxValue); //Imprimindo MIN e MAX do tipo byte
            Console.WriteLine("Tipo Float - MIN {0} - MAX {1}", float.MinValue, float.MaxValue); //Imprimindo MIN e MAX tipo Float
            

            Console.WriteLine(v_double2.ToString("F3")); //Imprimindo e Delimitando uma váriavel tipo Double a 3 casas decimais
            Console.WriteLine(v_double2.ToString("F2", CultureInfo.InvariantCulture)); // Imprime o Nº Double com a formação de ponto
            Console.Write("Seja Bem Vindo!"); // Não tem quebra de Linhas
            Console.WriteLine(v_int_m);
            Console.WriteLine(v_object);
            Console.WriteLine(v_obj);
            Console.WriteLine(v_string);
            Console.WriteLine(v_sbyte);
            Console.WriteLine(v_int);
            Console.WriteLine(v_byte);
            Console.WriteLine(v_long);
            Console.WriteLine(v_bool);
            Console.WriteLine(v_char);
            Console.WriteLine(v_char2);
            Console.WriteLine(v_float);
            Console.WriteLine(v_double);

            int idade = 40;
            double saldo = 50.85901;
            string nome = "Pedro Silva";

        }
    }
}
