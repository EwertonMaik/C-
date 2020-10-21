using System;
using System.Globalization;
using WorkingInterfaces.ComInterfaces.Services;

namespace WorkingInterfaces.ComInterfaces.Entities
{
    //Classe Principal
    class Program1
    {
        //Método Main
        static void Main(string[] args)
        {
            //Entrando com os Dados do Aluguel do Carro
            Console.WriteLine("*** PROGRAMA ALUGUEL DE CARROS ***");
            Console.WriteLine("Entre com os Dados do Aluguel ");
            Console.Write("Digite o Modelo do Carro : ");
            string modeloCar = Console.ReadLine();
            Console.Write("Digite a Data/Hora de Saída (dd/mm/yyyy hh:mm) : ");
            DateTime dtinicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Digite a Data/Hora de Retorno (dd/mm/yyyy hh:mm) : ");
            DateTime dtfim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Digite o Preço Por HORA : ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o Preço Por DIA : ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Declarado e Instânciado valores do Objeto Aluguel de Carros
            AluguelCarros aluguelCarros = new AluguelCarros(dtinicio, dtfim, new Veiculo(modeloCar));

            //Declarando e Instânciando Alguel Serviço
            AluguelServico aluguelServico = new AluguelServico(precoHora, precoDia, new ServicoTaxaBrasil() );
            aluguelServico.ProcessaFatura(aluguelCarros); // Chama método para processar Fatura Pagamento
            Console.WriteLine("Impressão Fatura : ");
            Console.WriteLine(aluguelCarros.Fatura);

        }
    }
}