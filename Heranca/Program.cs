using System;
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
            

            Console.WriteLine("Validando os Métodos de Sobreposição que foram desenvolvidos :");
            Console.WriteLine("Class Account / SuperClasse o padrão é o valor do Saque - R$ 5,00");
            Console.WriteLine("Class SavingsAccount / SubClasse de Account, fora Subscrito e não desconta nada para saque");
            Console.WriteLine("Class BusinessAccount / SubClasse de Account, fora Subscrito, manten o desconto dos R$ 5,00 e é cobrado mais R$ 2,00");

            //Todos com o Valor de R$ 1.000,00 na Conta
            Account         c01 = new Account(1, "Proprietario 01", 1000);
            BusinessAccount c02 = new BusinessAccount(2, "Proprietario 02", 1000, 0);
            SavingsAccount  c03 = new SavingsAccount(3, "Proprietario 03", 1000, 0);

            //Sacando R$ 900,00 das 3 Constas
            c01.WithDraw(900);
            c02.WithDraw(900);
            c03.WithDraw(900);

            //Consultando o Soldo das 3 Contas
            Console.WriteLine("Saque Account.........: {0}", c01.Balance);
            Console.WriteLine("Saque BusinessAccount.: {0}", c02.Balance);
            Console.WriteLine("Saque SavingsAccount..: {0}", c03.Balance);
        }
    }
}