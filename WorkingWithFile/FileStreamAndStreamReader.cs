using System;
using System.IO;

namespace WorkingWithFile
{
    //Classe para testar FileStream e StreamReader
    class FileStreamAndStreamReader
    {
        static void Main(string[] args)
        {
            //Declarando Variáveis
            string caminhoArquivo = @"C:\File1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;

            try
            {
                fileStream = new FileStream(caminhoArquivo, FileMode.Open); //Intânciado Objeto para apenas abri e o arquivo informado
                streamReader = new StreamReader(fileStream); //Instância o Objeto StreamReader a partir de FileStream
                //streamReader = new StreamReader( new FileStream(caminhoArquivo, FileMode.Open)); //Uma segunda forma de Instãnciar o  Objeto StreamReader
                //streamReader = File.OpenText(caminhoArquivo); //Terceira forma de Instãnciar o arquivo, e neste caso não precisar usar FileStream, apenas StreamReader e File
                string linha = streamReader.ReadLine();
                Console.WriteLine("Leu apenas uma Linha - " + linha);

                //Enquanto não chegar no final do arquivo
                int i = 1;
                while (! streamReader.EndOfStream) // Método que lê até o final do arquivo
                {
                    linha = streamReader.ReadLine();
                    Console.WriteLine($"Linha - {i} : {linha}");
                    i++;
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
            finally // Usando o Bloco Finally que sempre é executado para finalizar a conexão com o arquivo!
            {
                if (streamReader != null) streamReader.Close();
                if (fileStream != null) fileStream.Close();
                Console.WriteLine("Conexão Fechadas!");
            }

        }
    }
}
