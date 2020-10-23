using System;
using System.Collections.Generic;

namespace WorkingGenerics.HashSetAndSortedSet
{
    //Classe Principal
    class HashSetCurso
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando e Definindo 3 Listas HashSet, Cada uma representa um Curso
            //Uma lista não pode receber o código de aluno mais de uma vez, pois Hashset não permite 
            HashSet<int> cursoIngles = new HashSet<int>();
            HashSet<int> cursoPortug = new HashSet<int>();
            HashSet<int> cursoEspanh = new HashSet<int>();
            HashSet<int> todosAlunos;

            Console.Write("Quantos códigos de Aluno irá cadastrar no Curso Inglês : ");
            int qtd = int.Parse(Console.ReadLine());
            CadastroAlunoCurso(qtd, cursoIngles);

            Console.Write("Quantos códigos de Aluno irá cadastrar no Curso Português : ");
            qtd = int.Parse(Console.ReadLine());
            CadastroAlunoCurso(qtd, cursoPortug);

            Console.Write("Quantos códigos de Aluno irá cadastrar no Curso Espanhol : ");
            qtd = int.Parse(Console.ReadLine());
            CadastroAlunoCurso(qtd, cursoEspanh);

            todosAlunos = new HashSet<int>(cursoIngles);
            todosAlunos.UnionWith(cursoPortug);
            todosAlunos.UnionWith(cursoEspanh);
            Console.WriteLine("Total de Alunos : " + todosAlunos.Count);
        }

        //Método Cadastro código Aluno na Lista
        public static void CadastroAlunoCurso (int qtd, HashSet<int> curso)
        {
            for (int i = 0; i < qtd; i++)
            {
                Console.Write($"{i + 1}º Código :");
                int cod = int.Parse(Console.ReadLine());
                curso.Add(cod);
            }
        }
    }
}