using System;
using System.Globalization;

namespace ExpressoesLambdaDelegatesLINQ.MetodoSortAndComparionT.Versao01
{
    //Classe Produto, Implementando Interface IComparable do Tipo <Produto>
    //Implementa seu método também CompareTo
    class Produto : IComparable<Produto>
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

        //Método implementado da Interface IComparable
        public int CompareTo(Produto prod)
        {
            //Compara os Objetos do Tipo Produto em Caracter Maisculo
            return Nome.ToUpper().CompareTo(prod.Nome.ToUpper() );
        }
    }
}