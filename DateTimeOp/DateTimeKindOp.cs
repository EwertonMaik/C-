using System;

namespace Primeiro.DateTimeOp
{
    //Validando a Classe DateTimeKind - Hora Local E Universal
    class DateTimeKindOp
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando
            DateTime dt01 = new DateTime(2020, 10, 2, 18, 35, 25, DateTimeKind.Local );
            DateTime dt02 = new DateTime(2020, 10, 2, 18, 35, 25, DateTimeKind.Utc );
            DateTime dt03 = new DateTime(2020, 10, 2, 18, 35, 25 );

            Console.WriteLine("DateTime com Kind - Local  : " + dt01);
            Console.WriteLine("DateTime com Kind - UTC    : " + dt02);
            Console.WriteLine("DateTime sem Kind -        : " + dt03);

            Console.WriteLine("");

            Console.WriteLine("DT01----------------------------------------------------");
            Console.WriteLine("dt01                   : " + dt01 );
            Console.WriteLine("dt01.Kind              : " + dt01.Kind );
            Console.WriteLine("dt01.ToLocalTime()     : " + dt01.ToLocalTime() );
            Console.WriteLine("dt01.ToUniversalTime() : " + dt01.ToUniversalTime() );

            Console.WriteLine("");

            Console.WriteLine("DT02----------------------------------------------------");
            Console.WriteLine("dt02                   : " + dt02);
            Console.WriteLine("dt02.Kind              : " + dt02.Kind);
            Console.WriteLine("dt02.ToLocalTime()     : " + dt02.ToLocalTime());
            Console.WriteLine("dt02.ToUniversalTime() : " + dt02.ToUniversalTime());

            Console.WriteLine("");

            Console.WriteLine("DT03----------------------------------------------------");
            Console.WriteLine("dt03                   : " + dt03);
            Console.WriteLine("dt03.Kind              : " + dt03.Kind);
            Console.WriteLine("dt03.ToLocalTime()     : " + dt03.ToLocalTime());
            Console.WriteLine("dt03.ToUniversalTime() : " + dt03.ToUniversalTime());

            Console.WriteLine("");

            //Padrão ISO 8601
            // FORMATO yyyy-MM-ddTHH:mm:ssZ
            Console.WriteLine("--------------Padrão ISO 8601");
            Console.WriteLine("--------------FORMATO yyyy-MM-ddTHH:mm:ssZ");

            DateTime dt04 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime dt05 = DateTime.Parse("2000-08-15T13:05:58Z"); //Com o formato Padrão ISO

            Console.WriteLine("dt04 - Sem Formato ISO : " + dt04);
            Console.WriteLine("dt05 - Com Formato ISO : " + dt05);

            Console.WriteLine("");

            Console.WriteLine("DT04----------------------------------------------------");
            Console.WriteLine("dt04                   : " + dt04);
            Console.WriteLine("dt04.Kind              : " + dt04.Kind);
            Console.WriteLine("dt04.ToLocalTime()     : " + dt04.ToLocalTime());
            Console.WriteLine("dt04.ToUniversalTime() : " + dt04.ToUniversalTime());

            Console.WriteLine("");

            Console.WriteLine("DT05----------------------------------------------------");
            Console.WriteLine("dt05                   : " + dt05);
            Console.WriteLine("dt05.Kind              : " + dt05.Kind);
            Console.WriteLine("dt05.ToLocalTime()     : " + dt05.ToLocalTime());
            Console.WriteLine("dt05.ToUniversalTime() : " + dt05.ToUniversalTime());

            Console.WriteLine("");

            Console.WriteLine("dt05 - " + dt05.ToString("yyyy-MM-ddTHH-mm:ssZ") ); //Forma Impropria 
            Console.WriteLine("dt05 - " + dt05.ToUniversalTime().ToString("yyyy-MM-ddTHH-mm:ssZ") ); //Forma Correta
        }
    }
}