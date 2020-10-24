using System;
using System.Globalization;

namespace ExpressoesLambdaDelegatesLINQ.MetodoSortAndComparionT.Versao04
{
    //Classe Produto, sem Implementação da Interface IComparable
    class Produto
    {
        //Declaração AutoProperties
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Implementação método ToString para impressão
        public override string ToString()
        {
            return "Nome - " + Nome + " Preço - " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}