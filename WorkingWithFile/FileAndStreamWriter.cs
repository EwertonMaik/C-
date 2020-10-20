using System;
using System.IO;

namespace WorkingWithFile
{
    //Classe para testar Escrever em Arquivos com File e StreamWriter
    class FileAndStreamWriter
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarado uma duas variáveis strings contendo o arquivo 1 que tem texto e o 3 que está vazio
            string caminhoArquivo = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_13\File1.txt";
            string caminhoDestino = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_13\File3.txt";

            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo); // Lê todas linhas do arquivo e salva em um vetor de String

                //Usando bloco USING para os objetos instânciados serem encerrados ao termino do bloco
                //Objeto StreamWriter irá acessar o arquvo de Destino e adicionar Texto
                using (StreamWriter sw = File.AppendText(caminhoDestino) )
                {
                    foreach(string linha in linhas) //Percorre todo vetor da string
                    {
                        sw.WriteLine(linha.ToUpper() );//Grava linha a linha no arquivo de destino, baseado em cada linha percorrido peol foreach
                    }
                    Console.WriteLine("Arquivo copiado de File1 e gravado no arquivo File3!");
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}