using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WorkingInterfaces.InterfaceIComparable
{
    //Classe entidade Funcionário - Implementando Interface Icomparable
    class Funcionario : IComparable
    {
        //Atributos autoProperties
        public string Nome { get; set; }
        public double Salario { get; set; }

        //Definindo um Construtor para receber um string de funcionário e salvar em um vetor
        public Funcionario (string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(",");//Recebe a linha do arquivo csv e salva quebrado no vetor de strigs nome e salario
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        //Sobreposição com o Método ToString
        public override string ToString()
        {
            return "Nome : " + Nome + " Salário : " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        //Método Implementado da Interface IComparable
        //Interface IComparable - Interface para comparar um objeto com outro
        //menor, maior ou igual - Compara dois objetos retornando um número inteiro
        public int CompareTo(object obj)
        {
            if (! (obj is Funcionario) ) //Se o parâmetro do objeto recebido não for um Funcionário
            {
                throw new ArgumentException("Erro ArgumentException - Não é um Objeto Funcionário!");
            }

            Funcionario func = obj as Funcionario;//DownCasting, Converte um Tipo Generico(Object) para um especifico, no caso, Funcionário
            return Nome.CompareTo(func.Nome);
        }
    }
}