using System;
using ProjectPedido.Entities.Enum;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjectPedido.Entities
{
    //Classe entidade Order - Pedidos
    class Order
    {
        //Declarando atributos
        public Client Client { get; set;  }
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        //Construtores
        public Order()
        {
        }

        public Order(Client client, DateTime moment, OrderStatus orderStatus)
        {
            Client = client;
            Moment = moment;
            OrderStatus = orderStatus;
        }

        //Método para adicionar um OrderItem - Item de Pedido
        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        //Método para remover um OrderItem - Item de Pedido
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        //Método Total do Pedido, Busca dentro do laço o total de cada item pedido e soma
        public double Total()
        {
            double soma = 0.0;
            foreach (OrderItem obj in Items)
            {
                soma += obj.SubTotal();
            }
            return soma;
        }

        //Método para Impressão
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SUMÁRIO DA ORDER******************************");
            sb.AppendLine("Data Order : " + Moment );
            sb.AppendLine("Status Ord.: " + OrderStatus);
            sb.AppendLine("Cliente    : " + Client.Nome + " - " + Client.DataAniv.ToString("dd/MM/yyyy") + " - " + Client.Email);
            sb.AppendLine("ITEMS DO PEDIDO*******************************");
            int i = 1;
            foreach (OrderItem obj in Items)
            {
                sb.AppendLine($"{i}º Item Pedido - {obj.ToString()} ");
                i++;
            }
            sb.AppendLine($"Valor Total Pedido : {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}