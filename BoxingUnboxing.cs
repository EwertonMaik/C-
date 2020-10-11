using System;

namespace Primeiro
{
    //Exemplo de Boxing e Unboxing
    class BoxingUnboxing
    {
        //Método Main
        static void Main(string[] args)
        {
            //Exemplo 01 - BOXING
            //Processo de Conversão de um objeto tipo VALOR para um tipo REFERÊNCIA
            int x = 20; // Var tipo valor
            Object y = x;

            //Exemplo 02 - UNBOXING
            //Processo de Conversão de um Objeto tipo REFERÊNCIA para um tipo VALOR (Compatível)
            int a = (int) y; //a (Tipo valor) recebe um CATS (int) de y (Tipo Ref.)
        }
    }
}