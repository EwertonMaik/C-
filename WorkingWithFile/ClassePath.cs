using System;
using System.IO;

namespace WorkingWithFile
{
    //Classe para Testar Funções da Classe Path
    class ClassePath
    {
        static void Main(string[] args)
        {
            //Definindo variável para o caminho
            string varPath = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_13\File1.txt";

            //Testando e imprimindo valores sobre o Caminho do Arquivo
            Console.WriteLine(" DirectorySeparatorChar       : " + Path.DirectorySeparatorChar);
            Console.WriteLine(" PathSeparator                : " + Path.PathSeparator);
            Console.WriteLine(" GetDirectoryName             : " + Path.GetDirectoryName(varPath) );
            Console.WriteLine(" GetFileName                  : " + Path.GetFileName(varPath) );
            Console.WriteLine(" GetExtension                 : " + Path.GetExtension(varPath) );
            Console.WriteLine(" GetFileNameWithoutExtension  : " + Path.GetFileNameWithoutExtension(varPath) );
            Console.WriteLine(" GetFullPath                  : " + Path.GetFullPath(varPath) );
            Console.WriteLine(" GetTempPath                  : " + Path.GetTempPath() ); // Caminho da pasta tempo do SO
        }
    }
}