using System;
using System.IO;

namespace EstruturaException
{
    //Classe para Testar o Try - Catch - Finally
    class TryCatchFinally
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando um variável da Classe FileStream
            FileStream fs = null;

            //Iniciando Try - Catch - Finally
            try
            {
                fs = new FileStream(@"C:\arquivo.txt", FileMode.Open); //Instânciando e abrindo um arquivo, se não existir o catch irá captura-lo
                StreamReader sr = new StreamReader(fs); //Classe para Ler o FileStream
                string linha = sr.ReadLine();//Objeto será lido e salvo na variável string
                Console.WriteLine(linha);
            }
            catch (FileNotFoundException e) //SubClasse FileNotFoundException de Exception - Captura erro de arquivos
            {
                Console.WriteLine("Erro FileNotFoundException : " + e.Message);
            }
            finally //Bloco que é executado independente se houver ou não erro
            {
                if (fs != null)
                {
                    fs.Close();
                    Console.WriteLine("Conexão com o Arquivo Fechada!");
                }
            }
        }
    }
}