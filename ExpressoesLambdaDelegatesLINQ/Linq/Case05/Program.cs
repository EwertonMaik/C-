using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExpressoesLambdaDelegatesLINQ.Linq.Case05
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando e passando diretamente caminho do arquivo
            string caminho = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_17\Funcionarios.txt";
            Console.WriteLine("Caminho do Arquivo Lido : " + caminho);
            Console.Write("Digite o Salário : ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionario> list = new List<Funcionario>();

            try //Bloco Try para tratar erros
            {
                using (StreamReader sr = File.OpenText(caminho)) // Bloco using para fechar conexão com arquivos assim que encerrado
                {
                    while (!sr.EndOfStream) // Lê o arquivo enquanto não chegar ao Fim
                    {
                        string[] campo = sr.ReadLine().Split(',');
                        string nome = campo[0];
                        string email = campo[1];
                        double salario = double.Parse(campo[2], CultureInfo.InvariantCulture);
                        list.Add(new Funcionario(nome, email, salario) ); // Adicionado os Funcionários lidos do arquivo e salvo em lista
                    }

                    var emails = list.Where(obj => obj.Salario > limit).OrderBy(obj => obj.Email).Select(obj => obj.Email);

                    var sum = list.Where(obj => obj.Nome[0] == 'M').Sum(obj => obj.Salario);

                    Console.WriteLine("Imprimindo Valores da Lista");
                    Console.WriteLine("E-Mail das pessoa que o Salário é maior : " + limit.ToString("F2", CultureInfo.InvariantCulture));
                    foreach (string email in emails)
                    {
                        Console.WriteLine(email);
                    }

                    Console.WriteLine("Soma do Salário das pessoas que o nome começa com 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException : " + ioe.Message);
            }
        }
    }
}