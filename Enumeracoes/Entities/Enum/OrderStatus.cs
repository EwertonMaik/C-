using System;

namespace Enumeracoes.Entities.Enum
{
    //Enum que representa os Status dos Pedidos (Order)
    //Utiliza Enums
    enum OrderStatus : int
    {
        //Representação dos Itemns do Enum
        PendingPayment = 0, //PagamentoPendente
        Processing     = 1, //Processando
        Shipped        = 2, //Enviado
        Delivered      = 3  //Entregue
    }
}