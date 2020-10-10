using System;

namespace Primeiro
{
    //Classe para aplicação de Properties
    class Properties
    {
        //Declaração de Atributos com AutoProperties
        //as propriedades autoimplementadas tornam a declaração de propriedade mais concisa quando nenhuma
        //lógica adicional for necessária nos acessadores de propriedade
        // digitar prop e pressionar tab 2X é autocompletado
        public int MyProperty { get; set; } // MyProperty tem get e set public
        public int qtd { get; private set; } // qtd tem get public e set private

        //Declaração de Atributos para criar Properties Manualmente
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
        static void Main(string[] args)
        {
            //Instanciando a Classe
            Properties prop = new Properties();
            
            // Atributo Nome que tem acesso de Get e Set public - criado manualmente
            Console.WriteLine("Nome: ");
            prop.Nome = Console.ReadLine(); // Nome recebendo Valor
            Console.WriteLine(prop.Nome); // Nome sendo impresso

            // Atributo qtd que tem acesso Get public e Set privado
            Console.WriteLine("qtd :");
            Console.WriteLine(prop.qtd);
        }
    }
}
