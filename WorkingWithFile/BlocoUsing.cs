using System;
using System.IO;

namespace WorkingWithFile
{
    //Classe para testar o Bloco Using
    class BlocoUsing
    {
        //Metódo Main
        static void Main(string[] args)
        {
            //Declarando uma variável do caminho do arquivo
            string caminho = @"C:\File1.txt";

            try
            {
                //Bloco USING o que for instânciado dentro dele, não precisa ser Finalizado Manualmente, como no Finally
                //Ele encerra os Objetos automaticamente quando encerrar o bloco
                using (StreamReader sr = File.OpenText(caminho) )
                {
                    while (! sr.EndOfStream ) //Enquando não for o fim do arquivo
                    {
                        string linha = sr.ReadLine();
                        Console.WriteLine(linha);
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