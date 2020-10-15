using System;
using ProjectPedido.Entities.Enum;
using ProjectPedido.Entities;
using System.Globalization;

namespace ProjectPedido
{
    //Classe Princiapal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Inserindo os Valores do NOME / EMAIL e DATA ANIVERSARIO DO CLIENTE
            Console.WriteLine("PROGRAMA ORDER DE PEDIDO********************");
            Console.Write("Digite Nome : ");
            string nome = Console.ReadLine();
            Console.Write("Digite E-mail : ");
            string email = Console.ReadLine();
            Console.Write("Data Aniv. (DD/MM/YYYY) : ");
            DateTime dtAniv = DateTime.Parse(Console.ReadLine() );

            //Inserindo os STATUS do PEDIDO
            Console.WriteLine("DADOS DO PEDIDO********************************* ");
            Console.WriteLine("Digite Status do Pedido (PendingPayment/Processing/Shipped/Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine() );

            //Adicionando os dados do Cliente via Construtor e a Order(Pedido)
            Client client = new Client(nome, email, dtAniv);
            Order order = new Order(client, DateTime.Now, status);

            //Esta quantidade será usada para controlar o FOR na entrada dos ITENS DE PRODUTO
            Console.Write("Quantos Item de Produto de seja adicionar? : ");
            int n = int.Parse(Console.ReadLine() );

            //Entrada de ITENS DE PRODUTO dentro do FOR
            for (int i = 1; i <= n; i++){
                Console.WriteLine($"{i}º Item do Pedido");
                Console.Write("Nome Produto : ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço Produto : ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
                Console.Write("Quantidade Produto : ");
                int quantidade = int.Parse(Console.ReadLine() );

                Product prod = new Product(nomeProduto, preco);//Adicionando o Obejto Produto
                OrderItem orderitem = new OrderItem(prod, quantidade, preco); //Adicionando um Item de Pedido
                order.AddItem(orderitem); //Adicionando o Item Pedido na Pedido
            }

            //Imprimindo Resultados
            Console.WriteLine("");
            Console.WriteLine(order);

        }
    }
}