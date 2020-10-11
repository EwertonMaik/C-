using System;

namespace Primeiro.Struct
{
    class StructProgam
    {
        //Método Main
        static void Main(string[] args)
        {
            //Declarando uma variável Struct
            Struct str;

            //Sem instânciar é possivel já atribuir valores para os atributos
            str.x = 10;
            str.y = 20;
            Console.WriteLine(str); //Imprimindo valor

            //Pode ser intânciada também
            str = new Struct();
            Console.WriteLine(str); //Porém será impresso 0, pois não foi atribuido nenhum valor
        }
    }
}
