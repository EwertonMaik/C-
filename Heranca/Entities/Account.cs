namespace ProjectHerancaPolimorfismo.Heranca.Entities
{
    //Classe Account - Entidade de Conta/ será usada como Herança/Generica em outras classes especificas
    class Account
    {
        //Definindo atributos
        public int Number { get; private set; } // Nº Conta
        public string Holder { get; private set; } //Propietario Conta
        public double Balance { get; protected set;  } //Saldo da Conta - Atributo só poderá ser alterado da Classe Principal e a Classe Herdada

        //Construtores
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        
        //Método para Saque da Conta
        //Possui a declaração VITUAL - Indica que o método pode ser Sobrecrito em outra classe
        public virtual void WithDraw(double amount)
        {
            Balance -= amount + 5;
        }

        //Método para Depositar na Conta
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}