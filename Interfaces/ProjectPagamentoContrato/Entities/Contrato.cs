using System;
using System.Collections.Generic;

namespace WorkingInterfaces.ProjectPagamentoContrato.Entities
{
    //Classe Entidade Contrato
    class Contrato
    {
        //Declaração atributos AutoProperties
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double TotalValor { get; set; }
        public List<Prestacao> Prestacoes { get; set; }

        //Construtor
        public Contrato(int numero, DateTime data, double totalValor)
        {
            Numero = numero;
            Data = data;
            TotalValor = totalValor;
            Prestacoes = new List<Prestacao>(); //Dentro do Construtor é instânciado a Lista de Prestações do Contrato
        }

        //Método para adicionar uma ou mais prestação ao Contrato
        public void AdicionaPrestacao (Prestacao prestacao)
        {
            Prestacoes.Add(prestacao);
        }
    }
}