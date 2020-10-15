using System;

namespace ProjectPedido.Entities
{
    //Classe Entidade de Cliente
    class Client
    {
        //Declarando váriaveis com AutoProperties
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniv { get; private set; }

        //Construtores
        public Client()
        {
        }

        public Client(string nome, string email, DateTime dataAniv)
        {
            Nome = nome;
            Email = email;
            DataAniv = dataAniv;
        }
    }
}