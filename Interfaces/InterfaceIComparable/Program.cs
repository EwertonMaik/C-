using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorkingInterfaces.InterfaceIComparable
{
    //Classe com Método Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Atributo com o caminho do arquivo que será lido e comparado
            string caminho = @"C:\Udemy\Funcionarios.txt";

            try
            {
                //Executando dentro de um bloco using, após seu termino é finalizado também a conexão com o arquivo
                using (StreamReader sr = File.OpenText(caminho) )
                {
                    List<Funcionario> list = new List<Funcionario>(); //Cria uma lista de Funcionários que receberá os dados lidos do txt
                    while(! sr.EndOfStream)// Enquanto não foor o fim do arquivo
                    {
                        list.Add(new Funcionario(sr.ReadLine() ) ); //Recebe a linha lida passa ao Contrutor de Funcionário
                    }
                    list.Sort(); //Ordena a lista de Funcionários usando a Interface IComparable

                    //Imprimindo valores em Tela
                    foreach (Funcionario obj in list)
                    {
                        Console.WriteLine(obj);
                    }
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}