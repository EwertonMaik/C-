using System;
using System.Collections.Generic;

namespace Primeiro.Listas
{
    //Classe para Demonstrar utilização de Listas
    //Ela faz parte do namespace System.Collections.Generic
    class Listas
    {
        //Método Main
        static void Main(string[] args)
        {
            Console.WriteLine("ADICIONANDO-------------------------------------");
            //Instânciando uma Classe de Lista do tipo String
            List<string> l01 = new List<string>();
            

            //Instânciando uma Classe Lista e atribuindo valores
            List<string> l02 = new List<string> {"Paulo", "Pedro", "Carlos" };

            //Adicionando valores a Lista l01
            l01.Add("Produto 01");
            l01.Add("Produto 02");
            l01.Add("Produto 03");
            l01.Add("Produto 04");
            l01.Add("Remover");
            l01.Add("Cadastro_Com_Mais_Caracteres");
            l01.Insert(2, "Cadatro via Insert");// Insere Registro na Lista em uma posição informada, e o registro que estava na posição é empurado para seguinte

            //Adicionando valores na lista l02 via um for
            for (int i = 0; i <= 6; i++)
            {
                l02.Add("Nome " + i);
            }

            //Imprimindo Lista l01 e l02 via FOREACH
            foreach (string obj in l01)
            {
                Console.WriteLine("Lista l01: " + obj);
            }
            foreach (string obj in l02)
            {
                Console.WriteLine("Lista l02: " + obj);
            }

            //Imprimindo o tamanho da Lista
            Console.WriteLine("Tamanho da Lista l01: " + l01.Count);
            Console.WriteLine("Tamanho da Lista l02: " + l02.Count);

            //Pesquisando 1º Ocorrência de um valor na Lista
            Console.WriteLine("PESQUISANDO-------------------------------------");
            string busca = l01.Find( x => x[0] == 'C' );
            Console.WriteLine("Primeiro ocorrência com C na lista l01 : " + busca);
            busca = l02.Find(x => x[0] == 'N');
            Console.WriteLine("primeiro ocorrência com N na lista l02 : " + busca);

            //Pesquisando a última ocorrência de um valor na Lista
            string findlast = l01.FindLast( x => x[0] == 'P');
            Console.WriteLine("Última ocorrência com P na lista l01 : " + findlast);
            findlast = l02.FindLast( x => x[0] == 'N' );
            Console.WriteLine("Última ocorrência com N na lista l02 : " + findlast);

            //Pesquisa a 1ª ocorrencia de um valor , Retorna a Posição deste valor
            int posi1 = l01.FindIndex( x => x[0] == 'P');
            Console.WriteLine("Primeira Posição de valor Pesquisado em l01 : " + posi1);
            posi1 = l02.FindLastIndex( x => x[0] == 'N');
            Console.WriteLine("Última Posição de valor Pesquisado em l02 : " + posi1);

            //Filtrando uma Lista
            //Criado outra lista que irá receber a lista l01 baseado no filtro da expressão
            Console.WriteLine("FILTRANDO-------------------------------------");
            List<string> listafiltro = l01.FindAll(x => x.Length > 10);
            foreach (string obj in listafiltro)
            {
                Console.WriteLine("Lista Filtrada - " + obj);
            }

            //REMOVENDO itens da Lista
            Console.WriteLine("REMOVENDO-------------------------------------");
            l01.Remove("Remover"); // Remove o item apenas passado no parâmetro

            l02.RemoveAll(x => x[0] == '6'); // Remove itens baseado na expressão

            l01.RemoveAt(2); // Remove um item da posição informada no parâmetro

            l02.RemoveRange(2, 3); // Remove uma faixa de elementos da Lista, de uma posição até uma qtd informada

            //Imprimindo valores depois do Remove
            foreach (string obj in l01)
            {
                Console.WriteLine("Consultando depois dos Remove(s) na Lista l01: " + obj);
            }
            foreach (string obj in l02)
            {
                Console.WriteLine("Consultando depois dos Remove(s) na Lista l02: " + obj);
            }
        }
    }
}