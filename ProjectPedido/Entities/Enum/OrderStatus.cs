namespace ProjectPedido.Entities.Enum
{
    //Enum - Representa os Status das Order de Pedidos
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}