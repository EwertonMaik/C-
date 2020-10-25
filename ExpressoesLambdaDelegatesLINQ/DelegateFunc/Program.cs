using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressoesLambdaDelegatesLINQ.DelegateFunc
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma Lista do Tipo Produto
            List<Produto> list = new List<Produto>();

            //Adicionando valores a lista
            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.00));
            list.Add(new Produto("HD Externo", 80.00));
            list.Add(new Produto("CD / DVD RW", 15.00));

            //Declarado Lista de String que recebe o Objeto list transformado através da da Função LINQ Select
            //Para Caixa Alta, chamando a função passada como referência. ToList, é para converter de IEnumerable para Lista
            List<string> resultado = list.Select(CaixaAlta).ToList();
            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }

            //******* 2º Forma de Utilizar esta Função
            //Declarando o Delegate FUNC e fazendo-o receber a referência da Função
            Console.WriteLine();
            Console.WriteLine("Declarando o Delegate FUNC e fazendo-o receber a referência da Função");
            Func<Produto, string> dFunc = CaixaAlta;
            resultado = list.Select(dFunc).ToList();
            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }

            //******* 3º Forma de Utilizar esta Função
            //Fazendo o Delegate receber diretamente a expressão
            Console.WriteLine();
            Console.WriteLine("Fazendo o Delegate receber diretamente a expressão");
            dFunc = (p => p.Nome.ToUpper() );
            resultado = list.Select(dFunc).ToList();
            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }

            //******* 4º Forma de Utilizar esta Função
            //Fazendo a função Select receber diretamente a expressão
            Console.WriteLine();
            Console.WriteLine("Fazendo a função Select receber diretamente a expressão");
            resultado = list.Select( p => p.Nome.ToUpper() ).ToList();
            foreach (string obj in resultado)
            {
                Console.WriteLine(obj);
            }
        }
        //Método para retorna Nome em Caixa Alta
        static string CaixaAlta(Produto prod)
        {
            return prod.Nome.ToUpper();
        }
    }
}