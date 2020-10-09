using System;
using System.Globalization;

namespace Primeiro
{
    //Classe para representar estrutura e métodos de Produto
    class Produto
    {
        public string nome;
        public double preco;
        public int    quant;

        //Método Total de Produto
        public double ValorTotalEstoque()
        {
            return preco * quant;
        }

        //Método Override para ToString
        public override string ToString()
        {
            return nome + ", $ " + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + quant +
                " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
