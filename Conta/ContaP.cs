using System;
using System.Globalization;

namespace Primeiro.Conta
{
    //Classe Para inicio do Programa
    class ContaP
    {
        //Método main entry point
        static void Main(string[] args)
        {
            ContaBancaria cb; //Declarando um objeto para ContaBancaria

            Console.Write("Entre com o Nº da Conta: ");
            int num = int.Parse(Console.ReadLine() );

            Console.Write("Entre com o Titular da Conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá Deposito Inicial (S/N)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor deposito Inicial: ");
                double depinit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                cb = new ContaBancaria(num, nome, depinit);
            }
            else
            {
                cb = new ContaBancaria(num, nome);
                
            }

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(cb);

            //Deposito
            Console.Write("Entre com um valor para Deposito: ");
            double quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            cb.Deposito(quant);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(cb);

            //Saque
            Console.Write("Entre com um valor para Saque: ");
            quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(quant);
            Console.WriteLine("Dados da Conta Atualizados: ");
            Console.WriteLine(cb);
        }
    }
}
