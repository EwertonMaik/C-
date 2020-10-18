using System;
using System.Collections.Generic;
using System.Globalization;

namespace ProjectHerancaPolimorfismo.Employeer
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Declarando um lista de Empregados
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Programa Empregados e Terceirizados");
            Console.Write("Digite a quantidade de Empregados para cadastrar : ");
            int n = int.Parse(Console.ReadLine() );

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Cadastro Empregado {i} ");
                Console.Write("É Funcionário Terceirizado? (S/N) : ");
                char x = char.Parse(Console.ReadLine() );

                Console.Write("Nome : ");
                string nome = Console.ReadLine();
                Console.Write("Horas : ");
                int horas = int.Parse(Console.ReadLine() );
                Console.Write("Valor por Horas : ");
                double valorhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Se for Terceirizado é adicionado a despesa adicional na Lista Employee de
                //um Objeto OutsourcedEmployee
                if (x == 's' || x == 'S') // x.Equals("s")
                {
                    Console.Write("Despesa Adicional : ");
                    double despAd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                    list.Add( new OutsourcedEmployee(nome, horas, valorhoras, despAd) );
                }
                else
                {//Não sendo Terceirizado é adicionado um Objeto Employee na Lista
                    list.Add( new Employee(nome, horas, valorhoras) );
                }

            }//Fim For

            //Imprimindo valores
            Console.WriteLine("**************************************");
            Console.WriteLine("PAGAMENTOS");
            foreach (Employee obj in list)
            {
                Console.WriteLine($"Nome : {obj.Nome} - Valor Pago : {obj.Pagamento().ToString("F2", CultureInfo.InvariantCulture) } ");
            }

        }
    }
}