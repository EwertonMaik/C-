using System;
using System.Collections.Generic;

namespace WorkingGenerics.Case04MetodoGenericAndIComparable
{
    //Classe Com Operações de Calculo da Entidade Produto
    class CalculoServico
    {
        //Método com retorno, parâmetro e tipo Generic
        //Método possui a restrição também do Tipo Generico para Classe IComparable
        public T Maximo<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Erro ArgumentException - Lista Vazia!");
            }

            T maximo = list[0];
            for (int i = 0; i < list.Count; i++) //Percorre toda a Lista até seu tamanho
            {
                if (list[i].CompareTo(maximo) > 0 )
                {
                    maximo = list[i];
                }
            }
            return maximo;
        }
    }
}