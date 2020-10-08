using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Parse // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Entrada de dados String e convertendo para outros tipos de dados via método Parse
            int       n1 = int.Parse( Console.ReadLine() );
            char      n2 = char.Parse( Console.ReadLine() );
            double    n3 = double.Parse(Console.ReadLine() );
            double    n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ); //caso deseje usar o padrão de nº com (.) e não (,)
            float     n5 = float.Parse(Console.ReadLine() );

            //Entrada de Dados via ReadLine salvo em um vetor string 
            string[] vet2 = Console.ReadLine().Split(' '); // Split - Divide a String nos espaços e salva em cada posição do vetor
            string   nome1 = vet2[0];
            char     sexo = char.Parse(vet2[1]);
            int      idade1 = int.Parse(vet2[2]);
            double   altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou : ");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine(n5);

            Console.WriteLine(nome1);
            Console.WriteLine(sexo);
            Console.WriteLine(idade1);
            Console.WriteLine(altura);
            Console.WriteLine(altura.ToString("F3", CultureInfo.InvariantCulture) );
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
