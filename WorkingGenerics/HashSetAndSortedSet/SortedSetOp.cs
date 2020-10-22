using System;
using System.Collections.Generic;

namespace WorkingGenerics.HashSetAndSortedSet
{
    //Classe para testar SortedSet
    class SortedSetOp
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declaração variável SortedSet e definindo valores
            SortedSet<int> ss01 = new SortedSet<int>() { 0,1,2,3,4,5,6,7,8,9 };
            SortedSet<int> ss02 = new SortedSet<int>() { 5, 6, 7, 8, 9,10,11,12,13,14 };

            //UNIAO
            SortedSet<int> ss03 = new SortedSet<int>(ss01); //Declarado, Instânciado variável recebendo toda a coleção de ss01
            ss03.UnionWith(ss02); //ss03 recebe todos valores de ss02 que não exista em ss03

            //INTERSEÇÃO
            SortedSet<int> ss04 = new SortedSet<int>(ss01);
            ss04.IntersectWith(ss02);//ss04 recebe a interseção de valores entre ss04 e ss02

            //DIFERENÇA
            SortedSet<int> ss05 = new SortedSet<int>(ss01);
            ss05.ExceptWith(ss02);//ss05 recebe a diferença do que tem em ss05 e não existe em ss02

            //Chamando o Método para Imprimir
            ImprimirColecao(ss01);
            ImprimirColecao(ss02);
            ImprimirColecao(ss03);
            ImprimirColecao(ss04);
            ImprimirColecao(ss05);

        }

        //Método para Imprimir Coleção
        static void ImprimirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (T obj in colecao)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}