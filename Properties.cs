using System;

namespace Primeiro
{
    //Classe para aplicação de Properties
    class Properties
    {
        //Declaração de Atributos
        private string _nome;
        private int _idade;
        private double _salario;

        //Método Construtor
        public Properties()
        {
        }
        
        //Uma propriedade é um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.
        //Utilizando Properties em vez de criar os Métodos Get e Set
        public string Nome {
            get { return _nome; }
            set { 
                    if (value != null && value.Length > 1)
                    {
                        _nome = value;
                    }
                }
        }

        public int Idade
        {
            get { return _idade; }
        }

        public double Salario
        {
            get { return _salario; }
            set
            {
                if (value > 0)
                {
                    _salario = value;
                }
            }
        }

        //Método Main
        public void Main(string[] args)
        {
            //Instanciando a Classe
            Properties prop = new Properties();
            
            Console.WriteLine("Nome: ");
            prop.Nome = Console.ReadLine(); // Nome recebendo Valor
            Console.WriteLine(prop.Nome); // Nome sendo impresso
        }
    }
}
