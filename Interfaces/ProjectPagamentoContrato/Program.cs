using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using WorkingInterfaces.ProjectPagamentoContrato.Entities;
using WorkingInterfaces.ProjectPagamentoContrato.Services;

namespace WorkingInterfaces.ProjectPagamentoContrato
{
    //Classe Programa Principal
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Entrando com os valores do Contrato
            Console.WriteLine("*** PROGRAMA PAGAMENTO CONTRATOS ***");
            Console.Write("Digite Nº Constrato   : ");
            int numContrato = int.Parse(Console.ReadLine() );
            Console.Write("Digite Data Contrato  : ");
            DateTime dtContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Digite Valor Contrato : ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite Nº Prestações  : ");
            int mesesPrest = int.Parse(Console.ReadLine() );

            //Declara e instância um Contrato passando seus valores
            Contrato contrato = new Contrato(numContrato, dtContrato, valorContrato);
            //Declara e instância um Servico Contrato, passando em seu construtor a classe que implementou a interface
            ServicoContrato servicoContrato = new ServicoContrato(new ServicoPayPal() );
            servicoContrato.ProcessaContrato(contrato, mesesPrest);

            //Imprimindo Prestações do Contrato
            foreach (Prestacao obj in contrato.Prestacoes) //Percorre a Lista de Prestações contida no Objeto Contrato
            {
                Console.WriteLine(obj);
            }

        }
    }
}