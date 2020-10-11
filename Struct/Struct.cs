using System;

namespace Primeiro.Struct
{
    //struct tipo de dados valor
    //struct - Pode ser criado e já atribuido valores ou instânciado como uma classe e atribuido valores
    //Classes são estruturas por referência e aceita null
    //Struct pode ser criado com a estrutura abaixo
    struct Struct
    {
        //O tipos de dados primitivos são variavéis tipo valor Ex: int, double, float, byte etc...
        //Diferente das classes que são tipo referência
        public double x;
        public double y;

        //Sobrecarga para o Método ToString
        public override string ToString()
        {
            return "( " + x + ", " + y + ")";
        }

    }
}