using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Incremento_Decremento // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Operadore Aritméticos de Atribuição (Incremento e Decremento)
            int ope = 10;
            int v_rec;

            v_rec = ope++; // Variável v_rec recebe primeiro o valor de ope, e depois variável ope é incrementado + 1
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = ope--; // Variável v_rec recebe primeiro o valor de ope, e depois variável ope é decrementada - 1
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = ++ope; // Variável v_rec recebe o valor da variável ope já incrementada
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = --ope; // Variável v_rec recebe o valor da variável ope já decrementada
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
