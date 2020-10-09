using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Program // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Programa Calculos Retângulo - AREA / PERIMETRO / DIAGONAL
            Retangulo Ret = new Retangulo();
            Console.WriteLine("Programa Calculos Retângulo");
            Console.Write("Digite Base do Retângulo :");
            Ret.B = double.Parse(Console.ReadLine() );
            Console.Write("Digite Altura do Retângulo: ");
            Ret.A = double.Parse(Console.ReadLine() );

            Console.WriteLine("A Área do Retângulo é : {0}", Ret.AreaRetangulo() );
            Console.WriteLine("O Perimetro do Retângulo é: {0}", Ret.PerimetroRetangulo() );
            Console.WriteLine("A Diagonal do Retângulo é: {0}", Ret.DiagonalRetangulo() );
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
