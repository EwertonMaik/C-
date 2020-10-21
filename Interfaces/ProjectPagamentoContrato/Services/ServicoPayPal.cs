namespace WorkingInterfaces.ProjectPagamentoContrato.Services
{
    //Classe Serviço PayPal que implementa IServicoPagamentoOnline
    class ServicoPayPal : IServicoPagamentoOnline
    {
        //Atributos
        private const double TaxaPorcentagem = 0.02; //Taxa de Porcentagem de Pagamento Mensal 2%
        private const double JurosMensais = 0.01; // Juros de 1% para cada Parcela Boleto


        //Métodos Implementados de IServicoPagamentoOnline
        public double Juros(double valor, int meses)
        {
            return valor * JurosMensais * meses;
        }

        public double PagamentoTaxa(double valor)
        {
            return valor * TaxaPorcentagem;
        }
    }
}