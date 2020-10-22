using System;
using System.Globalization;

namespace WorkingGenerics.Case04MetodoGenericAndIComparable
{
    //Classe Entidade Usando Interface IComparable
    class Produto : IComparable
    {
        //Atributos AutoProperties
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Método Implementado da Interface IComparable
        //Usado para compara objetos entre tipos Produto
        public int CompareTo(object obj)
        {
            if (! (obj is Produto) )
            {
                throw new ArgumentException("Erro ArgumentException - Não é um tipo Produto!");
            }

            Produto prod = obj as Produto; //Realizando um DownCasting
            return Preco.CompareTo(prod.Preco);
        }

        //Método Sobreposto Tostring, para imprimir o objeto Produto
        public override string ToString()
        {
            return "Nome : " + Nome + " Preço : " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}