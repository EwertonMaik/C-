using System;

namespace Primeiro.TimeSpanOp
{
    //Classe para testar propriedades TimeSpan
    class TimeSpanPropriedades
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando Variáveis
            TimeSpan ts01 = TimeSpan.MaxValue;
            TimeSpan ts02 = TimeSpan.MinValue;
            TimeSpan ts03 = TimeSpan.Zero;
            TimeSpan ts04 = new TimeSpan(3, 20, 45, 55, 100); // DIAS/HORAS/MINUTOS/SEGUNDOS/MILLISEGUNDOS

            //Imprimindo Valores
            Console.WriteLine("TimeSpan.MaxValue - " + ts01);
            Console.WriteLine("TimeSpan.MinValue - " + ts02);
            Console.WriteLine("TimeSpan.Zero     - " + ts03);

            Console.WriteLine("-------------PROPRIEDADES----------------");
            Console.WriteLine("TimeSpan          : " + ts04);
            Console.WriteLine("Days              : " + ts04.Days );
            Console.WriteLine("TotalDays         : " + ts04.TotalDays);
            Console.WriteLine("Hours             : " + ts04.Hours);
            Console.WriteLine("TotalHours        : " + ts04.TotalHours);
            Console.WriteLine("Minutes           : " + ts04.Minutes);
            Console.WriteLine("TotalMinutes      : " + ts04.TotalMinutes);
            Console.WriteLine("Seconds           : " + ts04.Seconds);
            Console.WriteLine("TotalSeconds      : " + ts04.TotalSeconds);
            Console.WriteLine("Milliseconds      : " + ts04.Milliseconds);
            Console.WriteLine("TotalMilliseconds : " + ts04.TotalMilliseconds);
            Console.WriteLine("Ticks             : " + ts04.Ticks);

            Console.WriteLine("--------------OPERAÇÕES--------------------");
            TimeSpan ts05 = new TimeSpan(3, 45, 25); //HORAS/MINUTOS/SEGUNDOS
            TimeSpan ts06 = new TimeSpan(1, 10, 25); //HORAS/MINUTOS/SEGUNDOS

            Console.WriteLine("TimeSpan ts05     - " + ts05);
            Console.WriteLine("TimeSpan ts06     - " + ts06);
            Console.WriteLine("Soma TimeSpan Add - " + ts05.Add(ts06) );
            Console.WriteLine("TimeSpan Subtract - " + ts05.Subtract(ts06) );
            Console.WriteLine("TimeSpan Multiply - " + ts05.Multiply(2.0) ); //Multiplica o tempo por 2
            Console.WriteLine("TimeSpan Divide   - " + ts05.Divide(2.0) ); //Divide o tempo por 2
        }
    }
}