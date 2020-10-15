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
            OrderStatus or01 = Enum.Parse<OrderStatus>("Delivered"); // Forma 01
            Console.WriteLine("01 - Convertido de String P/ Enum - " + or01); 

            or01 = (OrderStatus) Enum.Parse(typeof(OrderStatus), "Delivered"); // Forma 02
            Console.WriteLine("02 - Convertido de String P/ Enum - " + or01);

            Enum.TryParse("Delivered", out or01); // Forma 03
            Console.WriteLine("03 - Convertido de String P/ Enum - " + or01);

        }
    }
}