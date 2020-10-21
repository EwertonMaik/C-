using System;
using System.Collections.Generic;
using System.Text;
using WorkingInterfaces.SemInterfaces.Entities;

namespace WorkingInterfaces.SemInterfaces.Services
{
    //Classe Aluguel do Serviço
    class AluguelServico
    {
        //Atributos AutoProperties
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ServicoTaxaBrasil _servicoTaxaBrasil = new ServicoTaxaBrasil();

        //Método Construtor
        public AluguelServico(double precoPorHora, double precoPorDia)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
        }

        //Método para Processar Fatura de Pagamento
        public void ProcessaFatura(AluguelCarros aluguelCarros)
        {
            //Pegando a duração de Fim e Inicio do Aluguel
            TimeSpan duracao = aluguelCarros.DataFim.Subtract(aluguelCarros.DataInicio);

            double pagBasico = 0.0;
            if (duracao.TotalHours <= 12.0) //If para Calcular o valor do pagamento basico, sendo por HORA ou por DIA
            {
                pagBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
                Console.WriteLine("Preço H: " + PrecoPorHora + " X Total Horas : " + Math.Ceiling(duracao.TotalHours));
            }
            else
            {
                pagBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
                Console.WriteLine("Preço D: " + PrecoPorDia + " X Total Dias : " + Math.Ceiling(duracao.TotalDays));
            }
            

            //Calculando o IMPOSTO
            double taxaImp = _servicoTaxaBrasil.Taxa(pagBasico);

            //Objeto Aluguel Carros, atributo Fatura recebe os valores do Objeto Fatura (pagamento básico e taxa)
            aluguelCarros.Fatura = new Fatura(pagBasico, taxaImp);

        }
    }
}