using System;

namespace WorkingInterfaces.ComInterfaces.Services
{
    //Classe ServicoTaxaBrasil implementando a Interface ITaxaServico
    class ServicoTaxaBrasil : ITaxaServico
    {
        //Método para Calcular taxa de Serviço no Brasil
        public double Taxa(double valor)
        {
            if (valor <= 100.0)
            {
                return valor * 0.2; //Calculo de 20%
            }
            else
            {
                return valor * 0.15; //Calculo de 15%
            }
        }
    }
}