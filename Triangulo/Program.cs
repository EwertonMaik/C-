using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Program // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Formula de Heron
            Triangulo x, y; // Variável X e Y representando a estrutura composta da classe Triângulo
            x = new Triangulo(); //Variável sendo instânciada
            y = new Triangulo();

            Console.WriteLine("Digite as Medidas do Triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as Medidas do Triângulo X");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // P = Perimetro
            double p = (x.A + x.B + x.C) / 2.0; // Calculando o Perimetro
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C) );

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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
