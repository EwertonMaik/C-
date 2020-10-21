using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace WorkingWithFile.ProductCsv
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            string caminho = @"C:\PlanilhaProd.csv";
            Console.WriteLine("Caminho + Arquivo : " + caminho);

            try
            {
                //Lê todos linhas do arquivo e salva em um vetor de strings
                string[] linhas = File.ReadAllLines(caminho);

                
                string nomeDiretorio = Path.GetDirectoryName(caminho); //Pega o Diretório do Caminho Informado C:\
                Console.WriteLine("Nome Diretório : " + nomeDiretorio);
                string pastaCriar = nomeDiretorio + @"NovaPasta"; // Concatena C:\ com a nova pasta que será criada ficando C:\NovaPasta
                Console.WriteLine("Pasta Criar : " + pastaCriar);
                string novoCaminho = pastaCriar + @"\Planilha.csv"; //Contatena e forma o caminho + arquivo final C:\NovaPasta\Planilha.csv
                Console.WriteLine("Novo Caminho : " + novoCaminho);

                //Cria a Pasta do caminho informado
                Directory.CreateDirectory(pastaCriar);

                //StreamWriter para abrir e gravar no arquivo de destino
                using (StreamWriter sw = File.AppendText(novoCaminho) )
                {
                    foreach (string linha in linhas) //Percorre todas as posições do vetor de strings
                    {
                        // Quebra o vetor de string de linhas em partes a partir da (,).
                        //A primeira linha será salva em novo vetor de strings na posição 0, 1, 2
                        //Consecultivamente até o foreach percorrer todas linhas
                        string[] fields = linha.Split(",");
                        string nome = fields[0];
                        double preco = double.Parse(fields[1]);
                        int qtd = int.Parse(fields[2]);

                        Product prod = new Product(nome, preco, qtd); //Produtos Adicionados ao Objeto Produto
                        sw.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture) ); //Produtos Gravados no arquivo .csv de destino
                        Console.WriteLine(prod.Nome + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture)); //Imprimindo valores em tela também
                    }
                }
                Console.WriteLine("Confira se o arquivo de destino foi criado e gravado!");
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}