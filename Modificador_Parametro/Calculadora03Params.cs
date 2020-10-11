using System;

namespace Primeiro.Modificador_Parametro
{
    //Classe usando o Modificador de Atributo PARAMS
    class Calculadora03Params
    {
        //Método Main
        static void Main(string[] args)
        {
            //Chamando a função para calcular soma
            Calculadora03Params.Soma(50, 100, 150, 200, 250); // Agora é possível os atributos sem intânciar o VETOR
        }

        //Método para soma Calculadora usando PARAMS e vetor
        public static int Soma(params int[] n) //Inserido o modificador PARAMS
        {
            int soma = 0;
            for (int i = 0; i < n.Length; i++) //Usa a função Length para pegar o tamanho do vetor
            {
                soma += n[i];
            }
            return soma;
        }
    }
}