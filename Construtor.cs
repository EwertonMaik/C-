using System;
namespace Primeiro
{
    //Classe Construtor
    class Construtor
    {
        public string Nome;
        public int    Idade;

        //Construtor vazio
        public Construtor()
        {
        }

        //Construtor usando palavra reservada this
        public Construtor(String Nome)
        {
            this.Nome = Nome;
        }

        //Construtor chamando 2 parãmetros
        //Recebe o par idade que atribuido a this.Idade, var global da classe
        //E this(Nome) chama o construtor acima de 1 parãmetro - Nome só e atribui o valor
        public Construtor(int Idade, string Nome) : this(Nome)
        {
            this.Idade = Idade;
        }

        //Sobrecarga do Método Construtor
        public Construtor(String Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}