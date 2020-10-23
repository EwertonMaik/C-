using System;
using System.Globalization;

namespace MetodosExtensao
{
    //Classe static contendo método de extensão para DateTime
    static class DateTimeExtensao
    {
        //Método static com referência para o próprio obejto que é chamado DateTime
        public static string TempoDuracao(this DateTime thisObj)
        {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);
            if (duracao.TotalHours < 24.0)
            {
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Horas";
            }
            else
            {
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Dias";
            }   
        }   
    }
}