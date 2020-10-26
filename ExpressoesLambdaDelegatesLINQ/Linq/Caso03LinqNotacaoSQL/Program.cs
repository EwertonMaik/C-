using System;
using System.Linq;
using System.Collections.Generic;
using ExpressoesLambdaDelegatesLINQ.Linq.Caso02DiversasOperacoes;

namespace ExpressoesLambdaDelegatesLINQ.Linq.Caso03LinqNotacaoSQL
{
    //Classe Principal para testar Operações com LINQ com Notação SQL
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Definindo algumas Categorias
            Categoria cat01 = new Categoria() { Id = 1, Nome = "Ferramentas", Nivel = 2 };
            Categoria cat02 = new Categoria() { Id = 2, Nome = "Computador", Nivel = 1};
            Categoria cat03 = new Categoria() { Id = 3, Nome = "Eletronico", Nivel = 1};

            //Definindo Produtos e usando uma Lista
            List<Produto> listProd = new List<Produto>() {
                new Produto() { Id = 1, Nome = "Computador", Preco = 1100.00, Categoria = cat02 },
                new Produto() { Id = 2, Nome = "Martelo", Preco = 90.00, Categoria = cat01 },
                new Produto() { Id = 3, Nome = "TV", Preco = 1700.00, Categoria = cat03 },
                new Produto() { Id = 4, Nome = "Notebook", Preco = 1300.00, Categoria = cat02 },
                new Produto() { Id = 5, Nome = "Serra", Preco = 80.00, Categoria = cat01 },
                new Produto() { Id = 6, Nome = "Tablet", Preco = 700.00, Categoria = cat02 },
                new Produto() { Id = 7, Nome = "Camera", Preco = 700.00, Categoria = cat03 },
                new Produto() { Id = 8, Nome = "Impressora", Preco = 350.00, Categoria = cat03 },
                new Produto() { Id = 9, Nome = "MacBook", Preco = 1800.00, Categoria = cat02 },
                new Produto() { Id = 10, Nome = "Barra Som", Preco = 700.00, Categoria = cat03 },
                new Produto() { Id = 11, Nome = "Nivel", Preco = 70.00, Categoria = cat01 },
            };
            
            //Comentado as Linhas do LINQ, e abaixo inserido a com notação SQL

            //Realizando Operações com LINQ - Filtering
            Console.WriteLine("Realizando Operações com LINQ - Filtering ***********************");
            //var linq01 = listProd.Where(x => x.Categoria.Nivel == 1 && x.Preco < 900.0);
            var linq01 = from p in listProd where p.Categoria.Nivel == 1 && p.Preco < 900.0 select p;
            Imprimir("LINQ Where : Nivel = 1 e Preço < 900 *** ", linq01);

            //var linq02 = listProd.Where(x => x.Categoria.Nome == "Ferramentas").Select(x => x.Nome);
            var linq02 = from p in listProd where p.Categoria.Nome == "Ferramentas" select p.Nome;
            Imprimir("LINQ Where / Select : Categoria = Ferramentas e Select apenas Nome", linq02);

            //var linq03 = listProd.Where(x => x.Nome[0] == 'C').Select(x => new { x.Nome, x.Preco, Nomecategoria = x.Categoria.Nome } );
            var linq03 = from p in listProd where p.Nome[0] == 'C' select new { p.Nome, p.Preco, CategoriaNome = p.Categoria.Nome };
            Imprimir("LINQ Where / Select (Anonymous) : Primeiro Letra Produto = C e Select NOME/PRECO/NOMECATEGORIA", linq03);

            //var linq04 = listProd.Where(x => x.Categoria.Nivel == 1).OrderBy(x => x.Preco).ThenBy(x => x.Nome);
            var linq04 = from p in listProd where p.Categoria.Nivel == 1 orderby p.Nome orderby p.Preco select p;
            Imprimir("LINQ Where / OrderBy / ThenBy : Categoria = 1 e Ordena por Preco Crescente e Nome", linq04);

            //var linq05 = linq04.Skip(2).Take(4);
            var linq05 = (from p in linq04 select p).Skip(2).Take(4);
            Imprimir("LINQ Skip / Take : Pula 2 Elementos e Pega 4 Elementos", linq05);

            //var linq06 = listProd.First(); //Se a lista for vazia, obtem erro!
            var linq06 = (from p in listProd select p).First();
            Console.WriteLine("LINQ First : Primeiro Elemento da Lista - " + linq06);
            Console.WriteLine();

            //var linq07 = listProd.Where(x => x.Preco > 3000.0).FirstOrDefault();//Se lista for Vazia, retorna vazio
            var linq07 = (from p in listProd where p.Preco > 3000 select p).FirstOrDefault();
            Console.WriteLine("LINQ FirstOrDefault : Primeiro Elemento da Lista - " + linq07);
            Console.WriteLine();

            //var linq08 = listProd.Where(x => x.Id == 3).SingleOrDefault(); //O tipo de retorno é único/ se obter mais de um resultado obtem erro
            var linq08 = (from p in listProd where p.Id == 3 select p).SingleOrDefault();
            Console.WriteLine("LINQ Where / SingleOrDefault : Retorna Único Valor " + linq08);
            Console.WriteLine();

            //var linq09 = listProd.Where(x => x.Id == 30).SingleOrDefault(); //Como não existe o Id 30, o retorno sera vazio
            var linq09 = (from p in listProd where p.Id == 30 select p).SingleOrDefault();
            Console.WriteLine("LINQ Where / SingleOrDefault : Retorna Único Valor, caso não exista retorna vazio " + linq09);


            //Realizando Operações com LINQ - Aggregation
            Console.WriteLine();
            Console.WriteLine("Realizando Operações com LINQ - Aggregation ******************************");

            //var linq10 = listProd.Max(x => x.Preco);
            var linq10 = (from p in listProd select p).Max(x => x.Preco);
            Console.WriteLine("LINQ Max - Maior Preço da Lista : " + linq10);

            //var linq11 = listProd.Min(x => x.Preco);
            var linq11 = (from p in listProd select p).Min(x => x.Preco);
            Console.WriteLine("LINQ Min - Menor Preço da Lista : " + linq11);

            //var linq12 = listProd.Where(p => p.Categoria.Id == 1).Sum(x => x.Preco);
            var linq12 = (from p in listProd where p.Categoria.Id == 1 select p).Sum(x => x.Preco);
            Console.WriteLine("LINQ Sum - Soma de Valores quando Categoria = 1 : " + linq12);

            //var linq13 = listProd.Where(p => p.Categoria.Id == 1).Average(x => x.Preco);
            var linq13 = (from p in listProd where p.Categoria.Id == 1 select p).Average(x => x.Preco);
            Console.WriteLine("LINQ Avarege - Média de Valores quando Categoria = 1 : " + linq13);

            //Tradando os valores caso a Lista seja vazia, e obtem erro na lista
            //var linq14 = listProd.Where(p => p.Categoria.Id == 5).Select(x => x.Preco).DefaultIfEmpty(0.0).Average();
            var linq14 = (from p in listProd where p.Categoria.Id == 5 select p.Preco).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("LINQ Where, filtra a lista que Id é igual a 5, e seleciona apenas campo Preço, Caso seja DefaultIfEmpty retorna 0, caso não Obtem a média : " +  linq14);

            //Caso a lista seja vazia a função de agregação retorna o valore inicial double 0.0
            //var linq15 = listProd.Where(p => p.Categoria.Id == 1).Select(x => x.Preco).Aggregate(0.0, (x, y) => x + y );
            var linq15 = (from p in listProd where p.Categoria.Id == 1 select p.Preco).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("LINQ Filtro com Where, Selecionando Preço, e Agregando com expressão : " + linq15);

            //Usando GroupBy para Listar Produtos Por Grupo
            Console.WriteLine();
            //var linq16 = listProd.GroupBy(x => x.Categoria);
            var linq16 = (from p in listProd select p).GroupBy(x => x.Categoria);
            Console.WriteLine("LINQ GrouBy - Listando os Produtos por Grupo da Categoria : ");
            foreach (IGrouping<Categoria, Produto> group in linq16)
            {
                Console.WriteLine("Nome Categoria : " + group.Key.Nome + " : ");
                foreach (Produto obj in group)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }
        }

        //Função para Imprimir Valores da Lista
        static void Imprimir<T>(string msg, IEnumerable<T> colecao)
        {
            Console.WriteLine(msg);
            foreach (T obj in colecao)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}