using System;
using System.IO;

namespace WorkingWithFile
{
    class FileInfoAndFile
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_13\File1.txt";
            string caminhoDestino = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_13\File2.txt";
            
            try
            {
                //Usando FileInfo
                FileInfo fileInfo = new FileInfo(caminhoArquivo); //Instância Objeto FileInfo do caminho do arquivo informado
                //Das diversas funções fornecidas pela Classe
                fileInfo.CopyTo(caminhoDestino); //Realiza Copia do arquivo! Para o caminho + nome do aquivo de destino, informado no parãmetro
                //Na segunda vez que executar o programa, o 2º arquivo irá já existir, e um Exceção será capturada
                Console.WriteLine("Copia do Arquivo Realizada com Sucesso para o novo Destino!");

                //Usando File para pegar o conteudo e imprimir em tela
                string[] linhas = File.ReadAllLines(caminhoArquivo); //Lê cada linha do arquivo e salva em um vetor de strings
                foreach (string obj in linhas)
                {
                    Console.WriteLine(obj);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Ocorreu Erro : " + ioe.Message);
            }
        
        }
    }
}