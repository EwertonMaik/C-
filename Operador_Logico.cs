using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Operador_Logico // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Operadores Lógicos
            // && - E
            // || - OU
            //  ! - NÂO

            int n1 = 10, n2 = 20, n3 = 30;

            //Duas Expressões para Testar o E (&&)
            if ( (n1 + n2) >= n3 && (n3 + n2) > n1  )
            {
                Console.WriteLine("Somente a Primeira Expressão for VERDADE e(&&) a Segunda Expressão for Verdade, isso será impresso! ");
            }

            //Duas Expressões para Testar o OU (||)
            if ((n1 + n2) >= n3 || (n3 + n2) < n1)
            {
                Console.WriteLine("Se pelo menos uma Expressão for VERDADE, isso será impresso! ");
            }

            //Duas Expressões para Testar o NÂO (!)
            if (  !((n1 + n2) >= n3) ||  !((n3 + n2) > n1 ) )
            {
                Console.WriteLine("O !(NÂO), nega o resultado das duas Expressões, e isso não será impresso! Pois os 2 resultados retornão TRUE e são mudados para False!");
            }
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
