using System;
using ProjetoWorker.Entities.Enum;
using System.Collections.Generic;

namespace ProjetoWorker.Entities
{
    //Classe - Entidade Worker / Trabalhadores
    class Worker
    {
        //Definido atributos com AutoProperties
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } // Tipo Level do Enum WorkerLevel
        public double Basesalary { get; set; }
        public Department Department { get; set; } // Tipo Department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //Tipo Lista de HoursContracts - Lista de Contratos

        //Definindo alguns Construtores
        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double basesalary, Department department)
        {
            Name = name;
            Level = level;
            Basesalary = basesalary;
            Department = department;
        }

        //Método para Adicionar Contrato
        public void AddContract (HourContract contract )
        {
            Contracts.Add(contract);
        }

        //Método para Remover Contrato
        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //Método para Verificar Quanto o Funcionário Ganhou
        public double Income(int year, int month)
        {
            double sum = Basesalary; // Soma recebe o Salário Base e os demais valores de contratos da condição do parãmetros informados
            foreach (HourContract contract in Contracts) // Percorre toda lista de Contratos
            {
                if (contract.Date.Year == year && contract.Date.Month == month) //Se ano e mes condizer com o do parâmetro
                {
                    sum += contract.TotalValue(); // Soma recebe ela + a função do valor total do contrato
                }
            }
            return sum;
        }
    }
}