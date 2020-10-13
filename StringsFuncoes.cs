using System;

namespace Primeiro
{
    //Classe para testar Funções Strings
    class StringsFuncoes
    {
        //Método Main
        static void Main(string[] args)
        {
             
            Console.WriteLine("FUNÇÕES COM STRING--------------------------");
            string str01 = "    ABC def GHI jkl MNO PQR stu VWX yz A    ";
            string str02 = str01.ToUpper();        //Muda todos Caracteres para MAIÚSCULO
            string str03 = str01.ToLower();        //Muda todos Caracteres para MINUSCULO
            string str04 = str01.Trim();           //Apaga todos os espaços em branco no inicio e fim da String
            int    str05 = str01.IndexOf("MN");    //Retorna a posição da String onde começa o MN
            int    str06 = str01.LastIndexOf("A"); //Retorna a posição da última ocorrência do parâmetro passado
            string str07 = str01.Substring(9);     //Cortar a string a partir da posição 9
            string str08 = str01.Substring(9, 15); //Corta o pedaço da string da posição 9 até + 15 posições
            string str09 = str01.Replace(" ", ".");//Substitui um caracter por outro
            string str10 = str01.Replace("A", "10");
            bool   str11 = String.IsNullOrEmpty(str01); //Verifica se a String é Null ou Vazia
            bool   str12 = String.IsNullOrWhiteSpace(str01); //Verifica se é NULL ou é apenas ESPAÇO em BRANCO
            string[] str13 = str01.Split(" "); //Corta a string em pedaços onte tem ( Um Espaço) - Neste caso, salvando em um vetor

            Console.WriteLine("Original    - " + str01 + "-");
            Console.WriteLine("ToUpper     - " + str02 + "-");
            Console.WriteLine("ToLower     - " + str03 + "-");
            Console.WriteLine("Trim        - " + str04 + "-");
            Console.WriteLine("IndexOf     - " + str05 + "-");
            Console.WriteLine("Lastindexof - " + str06 + "-");
            Console.WriteLine("Substring   - " + str07 + "-");
            Console.WriteLine("Substring   - " + str08 + "-");
            Console.WriteLine("Replace     - " + str09 + "-");
            Console.WriteLine("Replace     - " + str10 + "-");
            Console.WriteLine("IsNullOrEmpity - " + str11 + "-");
            Console.WriteLine("IsNullOrWhiteSpace - " + str12 + "-");
            for (int i = 0; i < str13.Length; i++)
            {
                Console.WriteLine("Split - Posição srt13[{0}] = {1} ", i, str13[i]);
            }
        }
    }
}