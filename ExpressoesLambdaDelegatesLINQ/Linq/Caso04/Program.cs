using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExpressoesLambdaDelegatesLINQ.Linq.Caso04
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarado direto o caminho do arquivo
            string caminho = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_17\Produtos.txt";
            Console.WriteLine(caminho);
            List<Produto> list = new List<Produto>(); // Lista de Produto

            try //Bloco Try para Tratamento de Erros
            {
                using (StreamReader sr = File.OpenText(caminho) ) //Finaliza a coxeção com arquivos quando o bloco é encerrado
                {
                    while (! sr.EndOfStream) //Enquanto não for o fim do arquivo
                    {
                        string[] campo = sr.ReadLine().Split(","); // Lê a linha e quebra as poosições na (,)
                        string nome = campo[0];
                        double preco = double.Parse(campo[1], CultureInfo.InvariantCulture);
                        list.Add(new Produto(nome, preco) ); //Adicionado o Produto a Lista
                    }
                }
                //Usando LINQ e expressões para calcular Média e Ordenar a Lista
                Console.WriteLine("*** Listando Média Produtos ***");
                var media01 = list.Average(x => x.Preco);
                var media02 = list.Select(p => p.Preco).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Média Produtos : " + media01.ToString("F2", CultureInfo.InvariantCulture) );
                Console.WriteLine("Média Produtos : " + media02.ToString("F2", CultureInfo.InvariantCulture) );

                Console.WriteLine("*** Listando Produtos Abaixo da Média ***");
                var resultList = list.Where(x => x.Preco < media01).OrderByDescending(p => p.Nome);
                foreach(Produto obj in resultList)
                {
                    Console.WriteLine("Nome : " + obj.Nome + " Preço : " + obj.Preco);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}