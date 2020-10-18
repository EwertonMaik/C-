using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectHerancaPolimorfismo.ClasseMetodoAbstract
{
    //Classe com método Main
    class Inicio
    {
        static void Main(string[] args)
        {
            //Declarando uma Lista de Figuras
            List<Figura> list = new List<Figura>();

            Console.WriteLine("*** PROGRAMA FIGURAS ***");
            Console.Write("Digite o Nº de Figuras que será cadastrado : ");
            int n = int.Parse(Console.ReadLine() );

            //Populando Lista
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Cadastro Nº {i} : ");
                Console.Write("É Retângulo ou Circulo? (r / c) : ");
                char x = char.Parse(Console.ReadLine() );
                Console.Write("Qual é a Cor? (Preto/ Azul / Vermelho) : ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine() );

                if (x == 'r' || x == 'R')
                {
                    Console.Write("Digita a Largura : ");
                    double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Digita a Altura : ");
                    double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add( new Retangulo(a, b, cor) );
                }
                else if (x == 'c' || x == 'C')
                {
                    Console.Write("Digite o Raio : ");
                    double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add( new Circulo(c, cor) );
                }
                else
                {
                    Console.WriteLine($"Valor {x} Inválido!");
                }
            }//Fim FOR

            //Imprimindo Valores
            Console.WriteLine("*** ÁREA DAS FIGURAS ***");
            foreach (Figura obj in list)
            {
                Console.WriteLine($"Cor - {obj.Cor} - Área - {obj.Area().ToString("F2", CultureInfo.InvariantCulture) }");
            }
        }
    }
}