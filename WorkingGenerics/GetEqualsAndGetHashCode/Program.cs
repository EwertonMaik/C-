using System;

namespace WorkingGenerics.GetEqualsAndGetHashCode
{
    //Classe para testar GetEquals e GetHashCode
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando variáveis
            string a = "Maria";
            string b = "Carla";
            string c = "Maria";

            //Testanto GetEquals
            Console.WriteLine("Equals - Maria é igual Carla : " + a.Equals(b) ); // Resultado FALSE
            Console.WriteLine("Equals - Maria é igual Maria : " + a.Equals(c) ); // Resultado TRUE

            //Testando GetHashCode
            Console.WriteLine("GetHashCode - a - Maria : " + a.GetHashCode() );
            Console.WriteLine("GetHashCode - b - Carla : " + b.GetHashCode() );
            Console.WriteLine("GetHashCode - c - Maria : " + c.GetHashCode() );

            Console.WriteLine("********************************************************");
            //**************************************
            //Testando Classe CLIENTE
            Cliente cli01 = new Cliente() { Nome = "Maria", Email = "maria@gmail.com" };
            Cliente cli02 = new Cliente() { Nome = "Carla", Email = "carla@gmail.com"};
            Cliente cli03 = new Cliente() { Nome = "Maria", Email = "maria@gmail.com" };

            Console.WriteLine("cli01.Equals(cli02) : " + cli01.Equals(cli02) );
            Console.WriteLine("cli01.Equals(cli03) : " + cli01.Equals(cli03));
            Console.WriteLine("cli01.GetHashCode() : " + cli01.GetHashCode() );
            Console.WriteLine("cli02.GetHashCode() : " + cli02.GetHashCode());
            Console.WriteLine("cli03.GetHashCode() : " + cli03.GetHashCode());

        }
    }
}