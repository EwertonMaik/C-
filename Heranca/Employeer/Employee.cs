using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHerancaPolimorfismo.Employeer
{
    //Classe Entidade Empregados, será herdada por OutsourcedEmployee
    class Employee
    {
        //Declaração Atributos com AutoProperties
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorHoras { get; set; }

        //Construtores
        public Employee()
        {
        }

        public Employee(string nome, int horas, double valorHoras)
        {
            Nome = nome;
            Horas = horas;
            ValorHoras = valorHoras;
        }

        //Método Pagamento que poderá ser Sobreposto
        public virtual double Pagamento()
        {
            return Horas * ValorHoras;
        }
    }
}