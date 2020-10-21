using System;

namespace WorkingInterfaces.SemInterfaces.Entities
{
    //Classe Entidade AluguelCarros
    class AluguelCarros
    {
        //Declarando atributos Atributos AutoProperties
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Veiculo  Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        //Método Construtor
        public AluguelCarros(DateTime dataInicio, DateTime dataFim, Veiculo veiculo)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}