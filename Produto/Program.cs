using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Program // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Programa Classe Produto
            Produto p = new Produto();

            Console.Write("Nome :");
            p.Nome = Console.ReadLine();
            Console.Write("Preço :");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Quantidade :");
            p.Quant = int.Parse(Console.ReadLine() );

            Console.WriteLine("Dados do Produto: " + p); //A concatenação com o Objeto p irá chamar automaticamente o método ToString

            Console.Write("Digite o Nº de Produtos a ser adicionado: ");
            int n_qtd = int.Parse(Console.ReadLine() );
            p.AdicionarProduto(n_qtd);
            Console.WriteLine("Dados Atualizado : " + p);

            Console.Write("Digite o Nº de Produtos a ser removidos: ");
            n_qtd = int.Parse(Console.ReadLine() );
            p.RemoverProduto(n_qtd);
            Console.WriteLine("Dados Atualizados : " + p);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
