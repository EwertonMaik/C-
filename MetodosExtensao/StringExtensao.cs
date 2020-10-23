using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosExtensao
{
    //Classe static para método de extensão
    static class StringExtensao
    {
        //Método de Extensão para cortar um valor de uma string
        public static string Cortar(this string thisObj, int valor)
        {
            if (thisObj.Length < valor){
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, valor);
            }
            
        }
    }
}