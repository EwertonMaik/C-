using System;

namespace Primeiro.Modificador_Parametro.Ref_Out
{
    //Classe para utilizar Modificador REF
    class ModificadorRef
    {
        //Método Main
        static void Main(string[] args)
        {
            int a = 10; ; //Variável declarada e atribuido valor para ser triplicado pela função
            ModificadorRef.Triple(ref a); //Assim como no método, aqui na chamada da função é preciso especificar REF, pois só assim o valor será referênciado
            Console.WriteLine(a);
        }

        //Método para Triplicar Número usando REF
        //É uma método void, que não retorna nada, porém o valor calculado dentro deste escopo
        //Só é passado para outro escopo devido ao Modificador REF
        //Se não tivesse REF, esse valor de x não era passado e destruido quando saisse do escopo
        public static void Triple(ref int x)
        {
            x *= 3;
        }
    }
}