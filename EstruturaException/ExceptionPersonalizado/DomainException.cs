using System;

namespace EstruturaException.ExceptionPersonalizado
{
    //Classe DomainException que Herda da Classe ApplicationException
    //Irá trabalhar com o tramamento das Excessões das Reservas
    class DomainException : ApplicationException
    {
        //Em seu construtur, ao ser instânciada, executa o construtor da SuperClasse também
        public DomainException (string message) : base(message)
        {
        }
    }
}