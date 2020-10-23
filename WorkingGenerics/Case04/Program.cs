using System;
using System.Collections.Generic;
using System.IO;

namespace WorkingGenerics.Case04
{
    //Classe Principal
    class Program
    {
        static void Main(string[] args)
        {
            //Declarado Lista Hashset do tipo RegistroLog  que não pode ter valor repetido
            HashSet<RegistroLog> listHS = new HashSet<RegistroLog>();

            Console.Write("Digite o Caminho do arquivo que será Lido : ");
            string caminho = Console.ReadLine();
            //C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_15\UsuarioLog.txt

            try
            {
                using (StreamReader sr = File.OpenText(caminho)) //Usando Bloco using para fechar a conexão com o arquivo assim se for encerrado
                {
                    while (!sr.EndOfStream) //Irá executar até o fim do Arquivo
                    {
                        string[] line = sr.ReadLine().Split(' '); //Pega a linha lida e quebra no espaço e salvo no vetor
                        string nome = line[0];
                        DateTime dthr = DateTime.Parse(line[1]);
                        listHS.Add(new RegistroLog(nome, dthr) ); //Adiciona na Lista HashSet de RegistroLog
                    }
                    Console.WriteLine("Total de Usuários : " + listHS.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro IOException : " +e.Message);
            }
        }
    }
}