using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enum;

namespace Enumeracoes
{
    //Classe Principal do Programa
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma Variável tipo Pedido e definindo os valores
            Order o = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(o);

            //Forma de Converter um ENUM para String
            string str01 = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("Convertido de Enum P/ String - " + str01);

            //Convertendo Tipo String para o Tipo ENUM
            OrderStatus or01 = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("Convertido de String P/ Enum - " + or01);

        }
    }
}