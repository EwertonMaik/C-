using System;
using System.Collections.Generic;
using System.IO;

namespace WorkingWithFile
{
    //Directory - Static não precisa instânciar
    //DirectoryInfo - Precisa Instânciar a classe
    class DirectoryAndDirectoryInfo
    {
        //Método Principal
        static void Main(string[] args)
        {
            string caminho = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\Projetos\WorkingWithFile\WorkingWithFile";
            
            try
            {
                Console.WriteLine("*** Classe Directory - Static não precisa instânciar ***");
                //LISTA TODOS DIRETÓRIOS A PARTIR DE UMA PASTA
                //Coleção IEnumerable do tipo String, recebendo todos os diretórios do caminho informado
                IEnumerable<String> folders = Directory.EnumerateDirectories(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("*** LISTAGEM DIRETÓRIOS ***");
                foreach (string obj in folders) //Percorre toda a coleção
                {
                    Console.WriteLine(obj); //Imprime cada diretório
                }

                //LISTA TODOS ARQUIVOS A PARTIR DE UMA PASTA
                //Coleção IEnumerable do tipo String, recebendo todos os diretórios do caminho informado
                IEnumerable<String> files = Directory.EnumerateFiles(caminho, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("*** LISTAGEM ARQUIVOS ***");
                foreach (string obj in files) //Percorre toda a coleção
                {
                    Console.WriteLine(obj); //Imprime cada diretório
                }

                //CRIAR UMA PASTA - Duas formas de informar o caminho
                Directory.CreateDirectory(caminho + "\\Pasta01"); //Informando 2 \\
                Directory.CreateDirectory(caminho + @"\Pasta02"); //Informando o @ e não precisa especificar 2 \\
                Console.WriteLine("Verifique se a pasta foi criada!");

                //Executando as mesmas operações anteriores, porém agora com
                //A classe Instânciada DirectoryInfo
                Console.WriteLine("****************************************************");
                Console.WriteLine("*** DirectoryInfo - Precisa Instânciar a classe ****");
                DirectoryInfo directoryInfo = new DirectoryInfo(caminho + @"\Pasta03");
                directoryInfo.Create();
                Console.WriteLine("Verifique se a pasta foi criada!");

                //Imprimindo os Diretórios de uma Pasta
                Console.WriteLine("*** Imprimindo Diretórios de uma PASTA ***");
                directoryInfo = new DirectoryInfo(caminho);
                IEnumerable<DirectoryInfo> foldes2 = directoryInfo.EnumerateDirectories(); //caminho, "*.*", SearchOption.AllDirectories
                foreach (DirectoryInfo obj in foldes2)
                {
                    Console.WriteLine(obj);
                }

                //Imprimindo os Arquivos de uma Pasta
                Console.WriteLine("*** Imprimindo Arquivos de uma PASTA ***");
                IEnumerable<FileInfo> files2 = directoryInfo.EnumerateFiles();
                foreach (FileInfo obj in files2)
                {
                    Console.WriteLine(obj);
                }

            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}