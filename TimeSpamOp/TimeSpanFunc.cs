using System;


namespace Primeiro.TimeSpanOp
{
    //Classe para testar TimeSpan
    class TimeSpanFunc
    {
        ///Método Main
        static void Main(string[] args)
        {
            //TimeSpam Representa uma Duração e é Tipo Valor Struct
            TimeSpan ts01 = new TimeSpan(); // Declarado e instãnciado a variável
            TimeSpan ts02 = new TimeSpan(800000000L); //Representação do tempo em Ticks (LONG)
            TimeSpan ts03 = new TimeSpan(2, 50, 300); //Atribuindo HORAS/MINUTOS/SEGUNDOS
            TimeSpan ts04 = new TimeSpan(1, 2, 50, 3000); // Atribuindo DIA/HORA/MINUTOS/SEGUNDOS
            TimeSpan ts05 = new TimeSpan(1, 2, 50, 3000, 800000); // Atribuindo DIA/HORA/MINUTOS/SEGUNDOS/MILISSEGUNDOS

            TimeSpan ts06 = TimeSpan.FromDays(1.5);      // Retorna o tempo de 1 dia e     12:00 horas
            TimeSpan ts07 = TimeSpan.FromHours(1.5);     // Retorna o tempo de 1 Hora e    30 Minutos
            TimeSpan ts08 = TimeSpan.FromMinutes(1.5);   // Retorna o tempo de 1 Minutos e 30 Segundos
            TimeSpan ts09 = TimeSpan.FromSeconds(1.5);   // Retorna o tempo de 1 Segundo e 5000000 Milissegundos
            TimeSpan ts10 = TimeSpan.FromMilliseconds(100); // Retorna o tempo de 00:00:00.1000000 Milissegundos

            //Imprimindo valores TimeSpan
            Console.WriteLine("Imprimindo Variáveis TimeSpan");
            Console.WriteLine("Apenas Declarado e Instânciado Variável : " + ts01);
            Console.WriteLine("Representando tempo em Ticks : " + ts02);
            Console.WriteLine("Usando Construtor 3 H/M/S ; " + ts03);
            Console.WriteLine("Usando Construtor 4 D/H/M/S : " + ts04);
            Console.WriteLine("Usando Construtor 5 D/H/M/S/MS " + ts05);

            Console.WriteLine("TimeSpan.FromDays(1.5)    : " + ts06);
            Console.WriteLine("TimeSpan.FromHours(1.5)   : " + ts07);
            Console.WriteLine("TimeSpan.FromMinutes(1.5) : " + ts08);
            Console.WriteLine("TimeSpan.FromSeconds(1.5) : " + ts09);
            Console.WriteLine("TimeSpan.FromMilliseconds(1.5) : " + ts10);



        }
    }
}
