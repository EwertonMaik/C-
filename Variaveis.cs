using System;
using System.Globalization;

namespace Primeiro
{
    class Variaveis
    {
        static void Main(string[] args)
        {    
            //Declaração de Variávies Locais
            String v_string;                   //Variável Tipo String apenas declarada
            String v_string2 = "Carlos Silva"; //Váriável Tipo String Declarada e Atribuido valor
            v_string = "Maria";                //Variável Tipo String Declara anteriormente sendo usada e atribuido valor
            v_string = Console.ReadLine();     //variável Tipo String irá receber valor via Médoto de entrada de dados
            v_string = v_string2;              //Variável Tipo String recebendo valor de outra variável String

            //Demais tipo de Variável Númerico
            sbyte  v_sbyte   = 127;          // MIN -128 - MAX 127
            byte   v_byte    = 255;          // MIN 0 - MAX 255
            int    v_int     = 2147483647;   // MIN -2147483648 - MAX 2147483647
            decimal v_dec    = 10;           // MIN -79228162514264337593543950335 - MAX 79228162514264337593543950335
            double  v_double = 4.5678;       // MIN -1,7976931348623157E+308 - MAX 1,7976931348623157E+308
            long    v_long   = 2147483648L;  // MIN -9223372036854775808 - MAX 9223372036854775807
            float   v_float  = 4.5F;         // MIN -3,4028235E+38 - MAX 3,4028235E+38

            bool   v_bool    = true;         // aceita true ou false
            char   v_char    = 'M';          // aceita apenas um Caracter, Ex: 'M', 'F'
            char   v_char2   = '\u0041';     // outra forma de representar um valor caracter pelo seu código Unicode
            
            //variável do Tipo Objeto podendo receber varios tipos de Dados
            Object v_object  = "João Brown";
            Object v_obj     = 4.5F;

            // Usando o Método WriteLine() para imprimir o MIN e MAX dos Typos Numericos via valor de suas constantes MinValue e MaxValue
            Console.WriteLine("Tipo sbyte - MIN {0} - MAX {1}", sbyte.MinValue, sbyte.MaxValue);    //Imprimindo MIN e MAX do tipo sbyte
            Console.WriteLine("Tipo byte  - MIN {0} - MAX {1}", byte.MinValue, byte.MaxValue);      //Imprimindo MIN e MAX do tipo byte
            Console.WriteLine("Tipo int   - MIN {0} - MAX {1}", int.MinValue, int.MaxValue);        //Imprimindo MIN e MAX do tipo int
            Console.WriteLine("Tipo Decimal - MIN {0} - MAX {1}", decimal.MinValue, decimal.MaxValue); //Imprimindo MIN e MAX do tipo Decimal
            Console.WriteLine("Tipo Double  - MIN {0} - MAX {1}", double.MinValue, double.MaxValue);   //Imprimindo MIN e MAX do tipo Double
            Console.WriteLine("Tipo Long    - MIN {0} - MAX {1}", long.MinValue, long.MaxValue);       //Imprimindo MIN e MAX do tipo Lon
            Console.WriteLine("Tipo Float   - MIN {0} - MAX {1}", float.MinValue, float.MaxValue);     //Imprimindo MIN e MAX tipo Float

            //Usando Console WriteLine para Imprimir as Variáveis
            Console.WriteLine("Imprimindo Variáveis! ");
            Console.WriteLine(v_string, v_string2);
            Console.WriteLine(v_sbyte);
            Console.WriteLine(v_byte);
            Console.WriteLine(v_int);
            Console.WriteLine(v_dec);
            Console.WriteLine(v_double);
            Console.WriteLine(v_long);
            Console.WriteLine(v_float);
            Console.WriteLine(v_bool);
            Console.WriteLine(v_char);
            Console.WriteLine(v_char2);
            Console.WriteLine(v_object);
            Console.WriteLine(v_obj);

            //Imprimindo e Delimitando uma váriavel tipo Double a 3 casas decimais
            Console.WriteLine(v_double.ToString("F3"));
            //Pertence ao Namespace System.Globalization. CultureInfo.InvariantCulture Proprieda de Objeto para tratar a entrada do tipo Double sem cultura de Idioma
            Console.WriteLine(v_double.ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}
