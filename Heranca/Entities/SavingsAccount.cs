namespace ProjectHerancaPolimorfismo.Heranca.Entities
{
    //Classe Entidade 
    class SavingsAccount : Account // Herança da Classe Account
    {
        //Atributo
        public double InterestRate { get; set; } // Taxa de Juros


        //Construtor
        public SavingsAccount()
        {
        }

        //Construtor com a chamada do Construtor da SuperClasse (Account)
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //Método para atualiar o saldo da conta baseado na taxa de juros
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}