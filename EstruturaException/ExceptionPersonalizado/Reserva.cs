using System;

namespace EstruturaException.ExceptionPersonalizado
{
    //Classe Entidade para Reserva
    class Reserva
    {
        //Declarando Atributos via AutoProperties
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        //Construtor
        public Reserva()
        {
        }

        public Reserva(int numeroQuarto, DateTime dataEntrada, DateTime dataSaida)
        {
            if (dataSaida <= dataEntrada) // Data de Saída não pode menor ou igual a de entrada
            {
                throw new DomainException("Erro : Data de Saída sempre é maior que Data de Entrada!");
            }

            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        //Método para calcular a duração em dias de um reserva
        public int DuracaoReserva()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada); // Pega a diferença entre datas
            return (int) duracao.TotalDays;
        }

        //Método para atualizar data da reserva
        public void AtualizaDataReserva(DateTime dtentrada, DateTime dtsaida)
        {
            DateTime agora = DateTime.Now; // Recebendo data do atual momento
            if (dtentrada < agora || dtsaida < agora)
            {
                throw new DomainException("Erro ; Datas devem ser maior que a Data Atual! ");
            }
            if (dtsaida <= dtentrada) // Data de Saída não pode menor ou igual a de entrada
            {
                throw new DomainException("Erro : Data de Saída sempre é maior que Data de Entrada!");
            }

            DataEntrada = dtentrada;
            DataSaida = dtsaida;
        }

        //Método Sobreposto para Imprimir as Reservas
        public override string ToString()
        {
            return "Dados da RESERVA "
                   + "Nº Quarto : " + NumeroQuarto
                   + " Data Ent. : " + DataEntrada.ToString("dd/MM/yyyy")
                   + " Data Saí. : " + DataSaida.ToString("dd/MM/yyyy")
                   + " Duração   : " + DuracaoReserva() + " Noites";
        }
    }
}