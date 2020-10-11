using System;
using System.Globalization;

namespace Primeiro.Conta
{
    //Classe Conta Bancaria
    class ContaBancaria
    {
        //Definição de Atributos usando Auto Properties
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }


        //Construtor para receber os 2 atributos
        public ContaBancaria(int numConta, string titular)
        {
            NumConta = numConta;
            Titular = titular;
        }

        //Construtor para receber 3 atributos, usando this para chamar o Construtor de 2 par.
        public ContaBancaria(int numConta, string titular, double depinicial) : this(numConta, titular)
        {
            Deposito(depinicial);
        }

        //Método Deposito Bancário
        public void Deposito (double valor)
        {
            Saldo += valor;
        }

        //Método Saque Bancário
        public void Saque (double valor)
        {
            Saldo -= valor + 5; //Valor do Saque + a taxa de Saque
        }

        //Sobrepondo o Método ToString
        public override string ToString()
        {
            return "Conta : " + NumConta + ", Titular : " + Titular + ", Saldo : R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
