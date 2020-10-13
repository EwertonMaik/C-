using System;

namespace Primeiro.Listas.Funcionario
{
    //Classe Funcionário para ser usado dentro de uma Lista
    class Funcionario
    {
        //Declarando atributos com AutoProperties
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //Método Construtor
        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        //Método para Atulizar Salário via Porcentagem
        public void AumentaSalarioP(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        //Método para Imprimir Lista de Funcionários
        public override string ToString()
        {
            return "ID : " + Id + " NOME : " + Nome + " SALÁRIO : " + Salario;
        }
    }
}