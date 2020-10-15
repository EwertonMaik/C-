using System;
using ProjetoWorker.Entities;
using ProjetoWorker.Entities.Enum;
using System.Globalization;

namespace ProjetoWorker
{
    //Classe Principal do Programa
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Inicio do Programa - Entrada de Dados
            Console.WriteLine("PROJETO TRABALHADOR");
            Console.Write("Entre com o Departamento : ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Entre Worker Data : ");
            Console.Write("Nome : ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine() );
            Console.Write("Base Salary : ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Passando os valores das variáveis para os contrutores
            Department dept = new Department(deptName);
            Worker worker = new Worker(nome, level, baseSalary, dept);

            //Validando com o usuário, quantos contratos será cadastrado para o trabalhador
            Console.Write("Quantos contratos para este trabalhador ? : ");
            int n = int.Parse(Console.ReadLine() );

            for (int i = 1; i <= n; i++)
            {
                //Entrando com os dados de DATA / VALOR POR HORA e DURAÇÃO DE HORAS
                Console.WriteLine("Entre com o {0}º Contrato : ",  i);
                Console.Write("Data (DD/MM/YYYY) : ");
                DateTime data = DateTime.Parse(Console.ReadLine() );
                Console.Write("Valor por Hora : ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write("Duração (Horas) : ");
                int hours = int.Parse(Console.ReadLine() );

                //Adicionando Valores para o construtor de HourContract
                HourContract contract = new HourContract(data, valueperhour, hours);
                worker.AddContract(contract);
            }

            //Parte Final
            Console.WriteLine("*******************");
            Console.Write("Entre com o MÊS e ANO para Calcular o Ganho (MM/YYYY) : ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse( monthAndYear.Substring(0, 2) ); // Recorta apenas 2 posições a partir de 0
            int year = int.Parse( monthAndYear.Substring(3) ); // Recorta a partir da posição 3

            Console.WriteLine("******************");
            Console.WriteLine("Nome - " + worker.Name );
            Console.WriteLine("Departamento - " + worker.Department.Nome );
            Console.WriteLine("Ganho do Mês/Ano : {0} é igual : {1}", monthAndYear, worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}