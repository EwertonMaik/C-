using System;
using System.Collections.Generic;

namespace WorkingGenerics.DictionaryAndSortedDictionary
{
    //Classe Principal
    class DictionaryOp
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando e Instânciando uma Variável do Tipo Dictionary
            Dictionary<string, string> dList = new Dictionary<string, string>();

            //Adicionando Valores ao Dictionary
            dList.Add("user", "Maria");         // 1ª Forma
            dList["email"] = "maria@gmail.com"; // 2ª Forma
            dList.Add("telefone", "9 9999-8888");
            dList["telefone"] = "9 7777-8888"; //Não aceita chaves repitidas, o valor da chave anterior será sobrescrita por essa
            dList.Add("cidade", "São Tupã");
            dList.Add("Estado", "São Paulo");
            dList.Add("Pais", "Brasil");

            //Impriminto Valores da Lista, manualmente e via foreach
            Console.WriteLine("*** Imprimindo Valores Dictionary ***");
            Console.WriteLine("dList[user] : " + dList["user"]);

            foreach (KeyValuePair<string, string> obj in dList)
            {
                Console.WriteLine("Key : " + obj.Key + " Values : " + obj.Value);
            }

            Console.WriteLine("Total Elementos - dList.Count : " + dList.Count);
            Console.WriteLine("Pesquisando Key - dList.ContainsKey(Pais) : " + dList.ContainsKey("Pais") );
            Console.WriteLine("dList.ContainsValue(São Paulo) : " + dList.ContainsValue("São Paulo") );

            dList.Remove("Pais"); //Remove a Chave Pais
            dList.Clear(); //Remove todas as chaves da Lista

            if (dList.ContainsKey("Sexo") )
            {
                Console.WriteLine(dList["Sexo"]);
            }
            else
            {
                Console.WriteLine("Dictionary Key não existe!");
            }
        }
    }
}