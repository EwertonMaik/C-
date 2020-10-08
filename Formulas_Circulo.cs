using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Formulas_Circulo // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Cálculo de Área de um Circulo
            //Area = π * R² OU Area = (π * D²) / 4
            //Diâmetro = 2 * R
            //Raio = D / 2
            
            Console.WriteLine("Cálculo de Área =>>>>");
            double PI = 3.14159;
            Console.WriteLine("Valor de PI é: {0} ", PI);
            Console.WriteLine("Digite o valor do Raio: ");
            double raio = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            double area = PI * ( raio * raio );
            Console.WriteLine("A área é: {0}", area.ToString("F4", CultureInfo.InvariantCulture) );
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
