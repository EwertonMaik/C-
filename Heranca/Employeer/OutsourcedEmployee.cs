using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHerancaPolimorfismo.Employeer
{
    //Classe Entidade OutsourcedEmployee 
    class OutsourcedEmployee : Employee
    {
        //Declaração atributo
        public double DespesaAdicional { get; set; }

        //Contrutores
        public OutsourcedEmployee()
        {
        }

        //Chamando o construtor da Classe Herdade
        public OutsourcedEmployee(string nome, int horas, double valorHoras, double despesaAdicional)
            :base(nome, horas, valorHoras)
        {
            DespesaAdicional = despesaAdicional;
        }


        //Sobrepondo método Pagamento da Classe Employee
        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesaAdicional;
        }

    }
}