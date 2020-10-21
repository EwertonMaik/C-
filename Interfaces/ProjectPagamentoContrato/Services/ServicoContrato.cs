using System;
using WorkingInterfaces.ProjectPagamentoContrato.Entities;

namespace WorkingInterfaces.ProjectPagamentoContrato.Services
{
    //Classe Servico Contrato
    class ServicoContrato
    {
        //Variável do Tipo IServicoPagamentoOnline / Interface
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        //Construtor
        //Ao ser instânciado o Construtor de ServicoConstrado, deverá ser informado
        //O serviço de Pagamento Online
        public ServicoContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        //Método para Processar o Contrato
        //Chamando e gerando os prestações
        public void ProcessaContrato (Contrato contrato, int meses)
        {
            double quotaBasica = contrato.TotalValor / meses; //Pega o valor do contrato e divide pela quantidade de meses que será parcelado

            for (int i = 1; i <= meses; i++){ //De 1 até a quantidade de meses informada
                DateTime data = contrato.Data.AddMonths(i); //O começo do pagamento dos boletos é 1 mês após a data do Contrato
                double quotaAtualizada = quotaBasica + _servicoPagamentoOnline.Juros(quotaBasica, i); //Calcula a quota básica para o mês de referência i
                double quotaCompleta = quotaAtualizada + _servicoPagamentoOnline.PagamentoTaxa(quotaAtualizada);
                contrato.AdicionaPrestacao(new Prestacao(data, quotaAtualizada));
            }
        }

    }
}