using System;

namespace Primeiro.DateTimeOp
{
    //Classe para validar Propriedades DateTime
    class DateTimePropriedades
    {
        //Método main
        static void Main(string[] args)
        {
            //Declarando Variável do Tipo DateTime, Usando Construtor 6 (ANO/MÊS/DIA/ HORA/MINUTOS/SEGUNDOS/MILLISEGUNDOS)
            DateTime dt01 = new DateTime(2019, 12, 25, 21, 35, 50, 275); // 2019/12/25 21:35:50

            //Imprimindo Váriavel dt01 em outros Formatos
            Console.WriteLine("Tudo : " + dt01);                    //Imprime toda extenção da variável
            Console.WriteLine("1  (Date)      : " + dt01.Date );          //Só a Data
            Console.WriteLine("2  (Day)       : " + dt01.Day);            //Só o Dia
            Console.WriteLine("3  (DayOfWeek) : " + dt01.DayOfWeek); //Dia da Semana
            Console.WriteLine("4  (DayOfYear) : " + dt01.DayOfYear); //Dia do Ano
            Console.WriteLine("5  (Hour)      : " + dt01.Hour);      //Horas
            Console.WriteLine("6  (Kind)      : " + dt01.Kind);      //
            Console.WriteLine("7  (Millisegundos) : " + dt01.Millisecond); //Millisegundos
            Console.WriteLine("8  (Minute)    : " + dt01.Minute);              //Minutos
            Console.WriteLine("9  (Month)     : " + dt01.Month);              //Mês
            Console.WriteLine("10 (Second)    : " + dt01.Second);             //Segundos
            Console.WriteLine("11 (Ticks)     : " + dt01.Ticks);              //Ticks
            Console.WriteLine("12 (TimeOfDay) : " + dt01.TimeOfDay);          //TimeSpan Tempo do Dia
            Console.WriteLine("13 (Year)      : " + dt01.Year);               //Ano

            //Métodos de Formatação em String To
            Console.WriteLine("ToLongDateString() : " + dt01.ToLongDateString() ); // Data Descrita
            Console.WriteLine("ToLongTimeString() : " + dt01.ToLongTimeString() ); // Hora Descrita
            Console.WriteLine("ToShortDateString(): " + dt01.ToShortDateString() );// Data resumida
            Console.WriteLine("ToShortTimeString(): " + dt01.ToShortTimeString() );// Hora resumida
            Console.WriteLine("ToString()         : " + dt01.ToString() );         // Padrão
            Console.WriteLine("ToString() Format  : " + dt01.ToString("yyyy-MM-dd HH:mm:ss") );    //Mascára de Formatação
            Console.WriteLine("ToString() Format  : " + dt01.ToString("yyyy-MM-dd HH:mm:ss:fff")); //Mascára de Formatação

            //Realizando Operações com a Variável DateTime
            DateTime dt02 = dt01.AddHours(48); //Variável dt02 recebendo a variável dt01 com + 2 horas

            Console.WriteLine("Realizando Operações com a Variável DateTime----------------");
            Console.WriteLine("Data Principal 01: " + "dt01 - " + dt01 );
            Console.WriteLine("Data Principal 02: " + "dt02 - " + dt02);
            Console.WriteLine("AddDays(3)       : " + "dt01 - " + dt01.AddDays(3) );     //Adicionando Dias
            Console.WriteLine("AddHours(2)      : " + "dt01 - " + dt01.AddHours(2) );    //Adicionando Horas
            Console.WriteLine("AddMinutes(10)   : " + "dt01 - " + dt01.AddMinutes(10) ); //Adicionando Minutos
            Console.WriteLine("AddMilliseconds(100)   : " + "dt01 - " + dt01.AddMilliseconds(100) ); //Adicionando Millisegundos
            Console.WriteLine("AddMonths(2)           : " + "dt01 - " + dt01.AddMonths(2) );     //Adicionando Mês
            Console.WriteLine("AddYears(3)            : " + "dt01 - " + dt01.AddYears(3) );      //Adicionando Anos
            Console.WriteLine("dt02.Subtract(dt01)    : " + dt02.Subtract(dt01) );               //Diferença entre Datas

        }
    }
}
