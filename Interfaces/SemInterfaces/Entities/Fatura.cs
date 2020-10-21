using System.Globalization;

namespace WorkingInterfaces.SemInterfaces.Entities
{
    //Classe entidade Fatura de pagamento aluguel do veiculo
    class Fatura
    {
        //Atributos AutoProperties
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        //Construtor
        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        //Propriedade Calculada para retornar Total Pagamento
        public double TotalPagamento
        {
            get { return PagamentoBasico + Taxa; }
        }

        //Método para Impressão Sobreposto ToString
        public override string ToString()
        {
            return "Pagamento Básico : "
                   + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nTaxa : "
                   + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                   + "\nTotal Pagamento : "
                   + TotalPagamento.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}