using System;
using System.Globalization;

namespace WorkingInterfaces.ProjectPagamentoContrato.Entities
{
    //Classe Entidade - prestaçãoes de um Contrato
    class Prestacao
    {
        //Declaração Atributos AutoProperties
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        //Construtor
        public Prestacao(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        //Método Sobreposto para Imprimir Prestações
        public override string ToString()
        {
            return "Data Vencimento : "
                  + DataVencimento.ToString("dd/MM/yyyy")
                  + " Valor : "
                  + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}