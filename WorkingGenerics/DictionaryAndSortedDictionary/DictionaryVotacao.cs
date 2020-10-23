using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WorkingGenerics.DictionaryAndSortedDictionary
{
    //Classe Principal
    class DictionaryVotacao
    {
        //Método Main
        static void Main(string[] args)
        {
            string caminho = @"C:\Udemy\C# COMPLETO 2020 Programação Orientada a Objetos + Projetos 37_horas\CAP_15\Votacao.txt";
            Console.WriteLine("Caminho do Arquivo Lido : " + caminho);

            try
            {
                using (StreamReader sr = File.OpenText(caminho) )
                {
                    Dictionary<string, int> list = new Dictionary<string, int>(); //Lista para adicionar os candidatos e aqt voto final
                    
                    while (! sr.EndOfStream) //Enquanto não for o fim do arquivo
                    {
                        string[] vet = sr.ReadLine().Split(","); //Quebra a linha da string em duas partes (nome e qtd_voto)
                        string nome = vet[0]; //Salva nome na posição 0
                        int qtdvoto = int.Parse(vet[1]); //Salva qtd votos na posição 1

                        if (list.ContainsKey(nome)) //Se a lista tiver o Chave comparada
                        {
                            list[nome] += qtdvoto; //É somado seu voto atual mais o novo
                        }
                        else //caso não
                        {
                            list[nome] = qtdvoto; //É adicionada seu primeiro voto a lista
                        }
                    }

                    //Imprimindo Resultado da Votação Lida
                    Console.WriteLine("*** RESULTADO DA VOTAÇÃO COMPUTADA ***");
                    foreach (KeyValuePair<string, int> obj in list)
                    {
                        Console.WriteLine("Nome : " + obj.Key + " - Total Votos : " + obj.Value);
                    }
                    Console.WriteLine(VencedorVotacao(list) );
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("Erro IOException - " + ioe.Message);
            }
        }
        
        //Método para Mostrar o Vencedor da Votação
        public static string VencedorVotacao(Dictionary<string, int> lista)
        {
            string nome = null;
            int voto = 0;
            foreach (KeyValuePair<string, int> obj in lista)
            {
                if (obj.Value > voto)
                {
                    nome = obj.Key;
                    voto = obj.Value;
                }
            }
            return $"Vencedor da Votação é {nome} com {voto} Votos!!!";
        }
    }
}