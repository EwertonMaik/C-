namespace WorkingInterfaces.ProjectPagamentoContrato.Services
{
    //Interface de Servico de Pagamento Online
    //Varias Classes de Serviço de Pagamento Online podem Implementar essa Interface
    interface IServicoPagamentoOnline
    {
        //
        double PagamentoTaxa(double valor);
        double Juros(double valor, int meses);
    }
}