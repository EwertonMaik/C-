using System.Globalization;
using System.Text;

namespace ProjectPedido.Entities
{
    //Classe entidade Item da Ordem de Pedido
    class OrderItem
    {
        //Declarando Atributos
        public Product Product { get; set; }
        public int Quantity { get; private set; }
        public double Price { get; private set; }

        //Construtor
        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity, double price)
        {
            this.Product = product;
            Quantity = quantity;
            Price = price;
        }

        //Método para Calcular Valor Total do Item da Order
        public double SubTotal()
        {
            return Quantity * Price;
        }

        //Método para Impressão do Itemn de Pedido - OrderItem
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Product.Nome}, Preço : {Price}, Quantidade : {Quantity}, SubTotal : R${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}