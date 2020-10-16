namespace ProjectHerancaPolimorfismo.Heranca.Entities
{
    //Classe BusinessAccount, especializada
    class BusinessAccount : Account // Classe recebendo herança da classe generica Account
    {
        //Atributos
        public double LoanLimit { get; set; } // Limite de Emprestimo

        //Contrutores
        public BusinessAccount()
        {
        }

        //Declarado o Contrutor de BusinessAccount e chamando o Construtor de Account com base()
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //Método para Emprestar Dinheiro
        public void Loan(double amount)
        {
            if (LoanLimit <= amount) //Se o valor emprestado estiver dentro do limit 
            {
                Balance += amount;
            }
        }
    }
}