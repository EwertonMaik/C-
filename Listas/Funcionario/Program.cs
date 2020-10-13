using System;
using System.Collections.Generic;
using System.Globalization;

namespace Primeiro.Listas.Funcionario
{
    //Classe Principal do Programa
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Criado e instânciado um Lista do Tipo Funcionário
            List<Funcionario> listFunc = new List<Funcionario>();

            //Lendo qts func será cadastrado
            Console.Write("Quantos Funcinários Deseja Cadastrar? ");
            int n = int.Parse(Console.ReadLine() );

            //Populando Lista de Produtos
            for (int i = 0; i < n; i++)
            {
                int id = i + 1;
                Console.Write("Digite Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listFunc.Add(new Funcionario(id, nome, salario) );
            }

            //Listando Produtos
            Console.WriteLine("Lista de Funcionários Cadastrados: ");
            foreach (Funcionario obj in listFunc)
            {
                //Console.WriteLine("Id : {0} - Nome : {1} - Salário : {2}", obj.Id, obj.Nome, obj.Salario );
                Console.WriteLine(obj);
            }

            //Buscando Funcionário que terá salario atualizado em porcentagem
            Console.Write("Digite o Id fo Funcionário que terá aumento: ");
            int idfunc = int.Parse(Console.ReadLine() );
            Funcionario func = listFunc.Find(x => x.Id == idfunc);

            if (func != null)
            {
                Console.Write("Digite a Porcentagem: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentaSalarioP(porc);
            }
            else
            {
                Console.WriteLine("Não Existe Cadastro para o Id {0}", idfunc);
            }

            //Imprimindo Valores Atualizados
            Console.WriteLine("Lista de Funcionários Atualizado!");
            foreach (Funcionario obj in listFunc)
            {
                //Console.WriteLine("Id : {0} - Nome : {1} - Salário : {2}", obj.Id, obj.Nome, obj.Salario);
                Console.WriteLine(obj);
            }
        }
    }
}