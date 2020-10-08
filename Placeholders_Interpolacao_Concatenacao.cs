using System; //NameSpace da Linguagem que contêm diversas classes e métodos
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Placeholders_Interpolacao_Concatenacao // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Declarando variáveis a serem usadas
            int     idade = 40;
            double  saldo = 50.85901;
            string  nome  = "Pedro Silva";

            // Imprimindo valores com WriteLine via PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F3} reias", nome, idade, saldo);

            // Imprimindo valores com WriteLine via INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F3} reais");

            //Imprimindo valores com WriteLine via CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            // ToString() usado para formatar o valor Double com 2 casas decimais e CultureInfo.InvariantCulture para formatar com ponto
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
