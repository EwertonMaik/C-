using System;
using System.Collections.Generic;

namespace ExpressoesLambdaDelegatesLINQ.PredicateAction
{
    //Classe Principal para Testar Predicate Action
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma Lista do Tipo Produto
            List<Produto> list = new List<Produto>();

            //Adicionando valores a lista
            list.Add(new Produto ("TV", 900.00) );
            list.Add(new Produto("Mouse", 50.00));
            list.Add(new Produto("Tablet", 350.00));
            list.Add(new Produto("HD Externo", 80.00));
            list.Add(new Produto("CD / DVD RW", 15.00));

            //Usando função de List.Foreach que recebe um Predicado Action e chamando Método void
            list.ForEach(AtualizaPreco);
            Console.WriteLine("*** Lista de Preços Atualizado em 10% ***");
            Console.WriteLine("Usando função de List.Foreach que recebe um Predicado Action e chamando Método void");
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }

            //******************************** 2ª Forma de Chamar o Método
            //Criado um Predicate Action que recebe a referência do Método AtualizaPreco
            Console.WriteLine();
            Action<Produto> actProd = AtualizaPreco;
            list.ForEach(actProd);
            Console.WriteLine("Criado um Predicate Action que recebe a referência do Método AtualizaPreco");
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }

            //******************************** 3ª Forma
            //Passando diretamente a expressão para o Action ou diretamente dentro do List.Foreach()
            Console.WriteLine();
            Console.WriteLine("Passando diretamente a expressão para o Action");
            actProd = p => { p.Preco += p.Preco * 0.1; };
            list.ForEach(actProd);
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }

            //OU 4º Forma diretamente dentro do List.Foreach()
            Console.WriteLine();
            Console.WriteLine("Passando diretamente a expressão dentro do List.Foreach()");
            list.ForEach( p => { p.Preco += p.Preco * 0.1; } );
            foreach (Produto obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        //Método aumentar Preço em 10%
        static void AtualizaPreco(Produto prod)
        {
            prod.Preco += prod.Preco * 0.1; //Aumenta preço em 10%
        }
    }
}