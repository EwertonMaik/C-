using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Operadores_Atribuicao // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Operadores de Atibuição
            int var = 100;
            string v_text = "ABC";
            
            //Usando WriteLine para imprimir o cálculo da expressão
            Console.WriteLine(var += 10); // var recebe var(100) + 10
            Console.WriteLine(var -= 10); // var recebe var(100) - 10
            Console.WriteLine(var *= 10); // var recebe var(100) * 10
            Console.WriteLine(var /= 10); // var recebe var(100) / 10
            Console.WriteLine(var %= 10); // var recebe var(100) % 10 (Operador de Resto) var recebe o resto da divição entre 100/10 = 0
            Console.WriteLine(v_text += "DEFGH"); // v_text recebe v_text + "DEFGH"

            //Poderia ser atribuido da seguinte forma também
            var = var + 10;
            var = var - 10;
            var = var * 10;
            var = var / 10;
            var = var % 10;
            v_text = v_text + "DEFGH";
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
