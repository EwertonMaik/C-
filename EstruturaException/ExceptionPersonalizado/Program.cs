using System;

namespace EstruturaException.ExceptionPersonalizado
{
    //Classe Principal 01 - Validando Dentro da Estutura do Programa
    class Program
    {
        //Método Main
        static void Main(string[] args)
        {
            //Comparado com exemplos anteriores desenvolvidos, os tratamento eram feitos em meio ao
            //código do programa Principal, agora está separado na Classe Reserva
            //TRY
            try
            {
                //Declarando variável Reserva
                Reserva res = null;

                //Entrada de Dados da RESERVA
                Console.WriteLine("***  PROGRAMA RESERVA ***");
                Console.Write("Digite Nº do quarto para reservar : ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Digite Data Entrada (dd/mm/yyyy): ");
                DateTime dtent = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite Data Saída (dd/mm/yyyy): ");
                DateTime dtsai = DateTime.Parse(Console.ReadLine());

                //O tratamento da entrada dos dados é feita no método contrutor e no método de AtualizaReserva
                //A validação não é mais feita com IF aqui dentro da classe Programa
                res = new Reserva(num, dtent, dtsai);
                Console.WriteLine(res);

                Console.WriteLine();
                Console.WriteLine("*** ATUALIZANDO DATA RESERVA ***");
                Console.Write("Digite Data Entrada (dd/mm/yyyy): ");
                dtent = DateTime.Parse(Console.ReadLine());
                Console.Write("Digite Data Saída (dd/mm/yyyy): ");
                dtsai = DateTime.Parse(Console.ReadLine());

                //Atualizado reserva com novos Dados
                //A validação não é mais feita com IF aqui dentro da classe Programa
                res.AtualizaDataReserva(dtent, dtsai);
                Console.WriteLine(res);
            }
            catch (DomainException de) // Captura as Exceções Implementadas para as reservas
            {
                Console.WriteLine("Erro DomainException : " + de.Message);
            }
            catch (FormatException fe) //Captura as Exceções de entrada de dados que não seja de seu Tipo
            {
                Console.WriteLine("Erro FormatException : " + fe.Message);
            }
            catch (Exception e) //Capturando uma eventual exceção generica não tradada
            {
                Console.WriteLine("Erro Inesperado Exception : " + e.Message);
            }
        }
    }
}