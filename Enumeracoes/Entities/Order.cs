using System;
using Enumeracoes.Entities.Enum;

namespace Enumeracoes.Entities
{
    //Classe - Entidade de Pedido
    class Order
    {
        //Atributos
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; } // Atributo do tipo OrderStatus (Enum)

        //Método Sobreposição usando ToString
        public override string ToString()
        {
            return "Order - " + Id + ", " + Moment + ", " + Status;
        }
    }
}