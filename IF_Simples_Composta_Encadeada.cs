using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class IF_Simples_Composta_Encadeada // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Estrutura Condicional IF ELSE
            //SIMPLES
            Console.WriteLine("Estrutura SIMPLES - Digite um Número: ");
            int v_01 = int.Parse(Console.ReadLine() );
            if (v_01 > 10)
            {
                Console.WriteLine("O valor digitado é maior que 10!");
            }

            //COMPOSTA
            Console.WriteLine("Estrutura COMPOSTA - Digite Número Inteiro: ");
            int v_par_impar = int.Parse(Console.ReadLine());

            if (v_par_impar % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }

            //ENCADEADA
            Console.WriteLine("Estrutura ENCADEADA - Digite que horas são!");
            int v_horas = int.Parse(Console.ReadLine() );

            if (v_horas < 12)
            {
                Console.WriteLine("Bom dia! é {0} horas da manhã!", v_horas);
            }
            else if (v_horas < 18)
            {
                Console.WriteLine("Boa tarde! é {0} horas da tarde!", v_horas);
            }
            else
            {
                Console.WriteLine("Boa noite! é {0} horas da noite!", v_horas);
            }
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
