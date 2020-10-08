using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class While // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Estrutura Condicional WHILE
            Console.Write("Digite um Número: ");

            double v_while = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (v_while >= 0.0) //Condição contiruará a ser executada enquando o Nº for >= 0.0. Caso seja menor, encerrará o programa
            {
                double v_raiz = Math.Sqrt(v_while); // Função que cálcula Raiz Quadrada de um Nº
                Console.WriteLine("Raiz Quadra: " + v_raiz.ToString("F2"), CultureInfo.InvariantCulture);
                Console.Write("Digite outro Número: ");
                v_while = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Programa Encerrado - Número Negativo");
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
