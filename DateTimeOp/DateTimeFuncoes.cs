using System;
using System.Globalization;

namespace Primeiro.DateTimeOp
{
    //Clase para testar DateTime, que estrutura de dados Struct
    public class DateTimeFuncoes
    {
        //Método Main
        public static void Main()
        {
            //Declarando  / Instânciando um dateTime e recebendo valor de agora
            DateTime dt01 = DateTime.Now;
            Console.WriteLine("DateTime.Now : " + dt01);

            //Passando valores pelo Construtor ANO/MES/DIA
            DateTime dt02 = new DateTime(2020, 10, 13);
            Console.WriteLine("DateTime usando parâmetros construtor : " + dt02);

            //Passando valores pelo Construtor ANO/MES/DIA HORAS/MINUTOS/SEGUNDOS
            DateTime dt03 = new DateTime(2020, 10, 13, 16, 48, 55);
            Console.WriteLine("DateTime ANO/MES/DIA HORAS/MINUTOS/SEGUNDOS : " + dt03);

            //DateTime.Today
            DateTime dt04 = DateTime.Today;
            Console.WriteLine("DateTime.Today : " + dt04);

            //Horário Universal
            DateTime dt05 = DateTime.UtcNow;
            Console.WriteLine("DateTime.utcNow : " + dt05);

            //Convertendo String para DateTime.Parse
            DateTime dt06 = DateTime.Parse("2019-10-13");
            Console.WriteLine("DateTime.Parse 2019-10-13 : " + dt06);
            dt06 = DateTime.Parse("2019/10/13");
            Console.WriteLine("DateTime.Parse 2019/10/13 : " + dt06);
            dt06 = DateTime.Parse("2019-10-13 17:02:55");
            Console.WriteLine("DateTime.Parse 2019-10-13 17:02:55: " + dt06);
            dt06 = DateTime.Parse("13/10/2020");
            Console.WriteLine("DateTime.Parse 13/10/2020 : " + dt06);
            dt06 = DateTime.Parse("13/10/2020 17:10:35");
            Console.WriteLine("DateTime.Parse 13/10/2020 17:10:35" + dt06);

            //Usando DateTime.ParseExact
            DateTime dt07 = DateTime.ParseExact("13-10-2020", "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime.ParseExact : " + dt07);

            DateTime dt08 = DateTime.ParseExact("13-10-2020 17:20:00", "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("DateTime.ParseExact : " + dt08);
        }
    }
}