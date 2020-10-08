using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Formula_Heron // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Formula de Heron
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Digite as Medidas do Triângulo X");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as Medidas do Triângulo X");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // P = Perimetro
            double p = (xA + xB + xC) / 2.0; // Calculando o Perimetro
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC) );

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4"), CultureInfo.InvariantCulture );
            Console.WriteLine("Área de Y = " + areaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (areaX > areaY)
            {
                Console.WriteLine("Maior Área é X");
            }
            else
            {
                Console.WriteLine("Maior Área é Y");
            }
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
