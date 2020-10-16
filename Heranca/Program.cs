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
        }
    }
}