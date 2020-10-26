using System;

namespace ExpressoesLambdaDelegatesLINQ.Linq.Case05
{
    //Classe Entidade Funcionário
    class Funcionario
    {
        //Atributos AutoProperties
        public String Nome { get; set; }
        public String Email { get; set; }
        public Double Salario { get; set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}