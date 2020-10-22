using System;
using System.Collections.Generic;

namespace WorkingGenerics.HashSetAndSortedSet
{
    //Classe para Testar HashSet
    class HashSetOp
    {
        //Método Main
        static void Main (string[] args)
        {
            //Declarando uma variável hashSet
            HashSet<string> listaHashSet = new HashSet<string>();

            //Adicionando valores a Lista manualmente
            listaHashSet.Add("Bicicleta");
            listaHashSet.Add("Moto");
            listaHashSet.Add("Carro");
            listaHashSet.Add("0123456789");

            //Verificando se um valor existe na Lista
            Console.WriteLine("listaHashSet.Contains(Carro) :" + listaHashSet.Contains("Carro") );
            Console.WriteLine("listaHashSet.Contains(Aviao) :" + listaHashSet.Contains("Aviao"));

            //Revome todos os elementos da lista que atendem o predicado
            listaHashSet.RemoveWhere(x => x.Length == 10); //Neste caso todos os valores que o tamanho seja igual a 10

            //Listando valores da Lista via foreach
            Console.WriteLine("*** Lista HashSet ***");
            foreach (string obj in listaHashSet)
            {
                Console.WriteLine(obj);
            }
                        
            //Remove um Elemento em especifico informado no parãmetro
            listaHashSet.Remove("Carro");

            //Remove todos os Elementos da Lista
            listaHashSet.Clear();
        }
    }
}