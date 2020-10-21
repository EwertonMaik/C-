using System;
using WorkingInterfaces.ComInterfaces.Entities;

namespace WorkingInterfaces.ComInterfaces.Services
{
    //Classe Aluguel do Serviço
    class AluguelServico
    {
        //Atributos AutoProperties
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaServico _taxaService; //Variável do Tipo ITaxaServico que é uma Interface

        //Método Construtor
        public AluguelServico(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _taxaService = taxaServico; // Ao ser Intânciado um AluguelServico, que será passado Qual classe de taxa implementa ITaxaServico
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
            double taxaImp = _taxaService.Taxa(pagBasico);

            //Objeto Aluguel Carros, atributo Fatura recebe os valores do Objeto Fatura (pagamento básico e taxa)
            aluguelCarros.Fatura = new Fatura(pagBasico, taxaImp);

        }
    }
}