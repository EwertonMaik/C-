using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Formula_Bhaskara // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Aplicando Exemplo de Calculo de Bhaskara
            double a = 1.0, b = -3.0, c = -4.0; //Variáveis declaradas e atribuidas
            double delta;
            double x1, x2;

            delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Usado método matemático do namespace System para calcular Potência - Math.Pow
            Console.WriteLine("Valor de Delta é: {0}", delta);

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Usado método matemático do namespace System para calcular Potência - Math.Sqrt
            Console.WriteLine("Valor de X1 é: {0}", x1);

            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Usado método matemático do namespace System para calcular Potência - Math.Sqrt
            Console.WriteLine("Valor de x2 é: {0}", x2);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
