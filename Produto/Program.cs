using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Program // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Programa Classe Produto
            Produto p = new Produto(); //Declarando e Instanciando Objeto Produto

            Console.Write("Nome :");
            p.nome = Console.ReadLine();
            Console.Write("Preço :");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Quantidade :");
            p.quant = int.Parse(Console.ReadLine() );

            Console.WriteLine("Dados do Produto: " + p); //A concatenação com o Objeto p irá chamar automaticamente o método ToString
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
