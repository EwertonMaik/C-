using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ProjectHerancaPolimorfismo.Product
{
    class Princiapal
    {
        //Método princiapl
        static void Main(string[] args)
        {
            //Declaração de uma Lista
            List<Produto> list = new List<Produto>();

            Console.WriteLine("*** PROGRAMA PRODUTOS ***");
            Console.Write("Digite o Nº de produtos para Cadastro : ");
            int n = int.Parse(Console.ReadLine() );

            char x = '0';
            for (int i = 1; i <= n; i++) // For para popular os dados na Lista de Produtos
            {
                Console.WriteLine($"CADASTRO {i}  **********************");
                Console.WriteLine("i - Importado / c - Comum / u - Usado");
                
                Console.Write("Qual o Tipo do Produto? : ");
                x = char.Parse(Console.ReadLine() );

                if (x == 'i' || x == 'c' || x == 'u') // Validar Valor Digitado
                {
                    Console.Write("Nome Produto : ");
                    string nome = Console.ReadLine();
                    Console.Write("Preço Produto : ");
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    switch (x) // SWITCH para identificar qual Tipo de Produto
                    {
                        case 'i': //Caso seja Produto IMPORTADO
                            Console.Write("Digite taxa Importação : ");
                            double txImport = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            list.Add(new ProdutoImportado(nome, preco, txImport));
                            break;

                        case 'c': //Caso seja Produto COMUM
                            list.Add(new Produto(nome, preco));
                            break;

                        case 'u': //Caso seja Produto USADO
                            Console.Write("Digite Data de Fabricação (dd/mm/yyyy) : ");
                            DateTime dt = DateTime.Parse(Console.ReadLine());
                            list.Add(new ProdutoUsado(nome, preco, dt));
                            break;
                    }
                } else
                {
                    Console.WriteLine($"Valor {x} Inválido! ");
                    Console.WriteLine("i - Importado / c - Comum / u - Usado");
                    break;

                } //FIM If Else

            }//Fim FOR

            if (x == 'i' || x == 'c' || x == 'u')
            {
                //Imprimindo Valores
                Console.WriteLine("**********************************");
                Console.WriteLine("ETIQUETA DOS PRODUTOS ************");
                foreach (Produto obj in list) //Foreach para percorrer a Lista e Imprimir valore
                {
                    Console.WriteLine(obj.EtiquetaPreco());
                }
            }

        }
    }
}