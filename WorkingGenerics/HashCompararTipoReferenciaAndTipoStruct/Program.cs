using System;
using System.Collections.Generic;

namespace WorkingGenerics.HashCompararTipoReferenciaAndTipoStruct
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarado e instânciado uma Lista HashSet de Produto
            HashSet<Produto> a = new HashSet<Produto>(); //Tipo Referência
            a.Add(new Produto("TV", 900.0));
            a.Add(new Produto("Notebook", 1200.0));

            //Declarado e instânciado uma Lista HashSet de Ponto
            HashSet<Ponto> b = new HashSet<Ponto>(); //Tipo Valor/Struct
            b.Add(new Ponto(3, 4));
            b.Add(new Ponto(5, 10));

            //Declarado e instânciado um novo Objeto Produto e passado seus valores
            Produto prod = new Produto("Notebook", 1200.0); //Tipo Referência
            //Retorna FALSE, pois comparam pela referência do Objeto
            Console.WriteLine("a.Contains(prod) : " + a.Contains(prod) + " - Retorna FALSE, pois comparam pela referência do Objeto. Se tiver implementado Equals e GetHashCode, retorna TRUE");

            ////Declarado e instânciado um novo Objeto Ponto e passado seus valores
            Ponto ponto = new Ponto(5, 10); //Tipo Valor/struct
            //Retorna TRUE, pois são do tipo STRUCT, comparam por valor da váriável
            Console.WriteLine("b.Contains(ponto) :" + b.Contains(ponto) + " - Retorna TRUE, pois são do tipo STRUCT, comparam por valor da váriável"); 
        }
    }
}