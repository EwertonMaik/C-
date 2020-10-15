using System;

namespace ProjetoWorker.Entities
{
    //Classe - Entidade Horas de Contrato
    class HourContract
    {
        //Declarando Váriáveis e usando AutoProperties
        public DateTime Date { get; set; } //Data
        public double ValuePerHour { get; set; } // Valor Ganho por Horas
        public int Hours { get; set; } //Horas

        //Definindo Alguns Construtores
        public HourContract()
        {
        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            ValuePerHour = valueperhour;
            Hours = hours;
        }

        //Método para Calcular Total de Horas
        public double TotalValue()
        {
            return Hours * ValuePerHour; //Horas * pelo Valore de Horas
        }
    }
}