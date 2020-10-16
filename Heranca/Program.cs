using ProjectHerancaPolimorfismo.Heranca.Entities;

namespace ProjectHerancaPolimorfismo.Heranca
{
    class Program
    {
        //Método Principal
        static void Main(string[] args)
        {
            //Declarando e instânciando a classe BusinessAccount
            BusinessAccount businessAccount = new BusinessAccount(84559, "Pedro Paulo", 2000, 1000);

            //businessAccount.Balance = 5000; // Obtem erro, atributo é Protected, só pode ser usando dentro de Account e BusinnesAccount

            /*  ******************************************************  */

            Account acc01 = new Account(12345, "Carlos", 0.0); //Classe Genérica / SuperClasse
            BusinessAccount bac01 = new BusinessAccount(67891, "Jonas", 0.0, 300); // Classe Especifica / SubClasse / Herança de Account
            SavingsAccount sac01 = new SavingsAccount(7532, "Maria", 2000, 1);     // Classe Especifica / SubClasse / Herança de Account

            //Upcasting Conversão (SubClasse para SuperClasse) - Implícito
            //Uso Polimorfismo
            acc01 = bac01;
            Account acc02 = new BusinessAccount(159753, "Silvio", 1000, 300);
            acc01 = sac01;
            Account acc03 = new SavingsAccount(8815, "Tereza", 1000, 1);

            //Downcasting Conversão (SuperClasse / SubClasse) - Explicito
            //Uso As, Is e Métodos
            BusinessAccount bac02 = (BusinessAccount) new Account(25845, "Flavia", 6000);
            BusinessAccount bac03 = acc01 as BusinessAccount; //Outra forma de explicitar a Conversão

            //bac01 = acc01; //Erro, precisa ser especificado o explicitamente
            bac01 = (BusinessAccount) acc01;
            //bac02 = (BusinessAccount) sac01; // Erro, não é possível de SubClasse para SubClasse/ Ex: BusinessAccount = SavingsAccount

            if ( acc03 is BusinessAccount) // Verificar se acc03 é uma instância de BusinessAccount, porém é SavingsAccount
            {
                bac02 = (BusinessAccount) acc03; // Isso não será executado, e também obteria erro, não é possível de SubClasse para SubClasse
            }
        }
    }
}