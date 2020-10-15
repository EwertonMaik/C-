using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPedido.Entities
{
    //Classe entidade de Produtos
    class Product
    {
        //Declarando Variáveis
        public string Nome { get; set; }
        public double Price { get; private set; }

        //Construtores
        public Product()
        {
        }

        public Product(string nome, double price)
        {
            Nome = nome;
            Price = price;
        }
    }
}