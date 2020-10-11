using System;

namespace Primeiro.Modificador_Parametro.Ref_Out
{
    //Classe para utilizar Modificador OUT
    class ModificadorOut
    {
        //Método Main
        static void Main(string[] args)
        {
            //Chamada do Método
            int a = 10; // Variável declarada e inicializada, será duplicada pelo Método Triple
            int triple; //Variável apenas declarada, irá receber o valor de (a) triplicado
            ModificadorOut.Triple(a, out triple); //Passado o valor de (a), e o resultado virá para a variável (triple)
            Console.WriteLine(triple);
        }

        //Método para Triplicar Número usando OUT
        //Comparado ao REF, a variavél OUT não precisa ser inicializada
        //É uma método void, que não retorna nada, porém o valor calculado dentro deste escopo
        //Só é passado para outro escopo devido ao Modificador OUT
        public static void Triple (int valor, out int resultado)
        {
            resultado = valor * 3;
        }
    }
}