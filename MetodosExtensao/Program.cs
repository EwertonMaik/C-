using System;

namespace MetodosExtensao
{
    //Classe Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            Console.WriteLine("*** Usando a Classe DateTimeExtensão ***");
            //Declarando/Instânciado e Definindo um valor de Data Hora
            DateTime dt = new DateTime(2020, 10, 21, 15, 00, 00);

            //Chamando o Método de Extensão desenvolvido
            Console.WriteLine("Data Variável Atribuida : " + dt);
            Console.WriteLine("Tempo de Duração : " + dt.TempoDuracao() );

            //**************************************************************
            Console.WriteLine("*** Usando a Classe StringExtensao ***");
            string msg = "Seja Bem Vindo a 2021 !!!";
            //Chamando Métedo de Extensão
            Console.WriteLine("String Antes : " + msg);
            Console.WriteLine("String Agora : " + msg.Cortar(8));
        }
    }
}