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
            return Preco * Quant;
        }

        //Método Remover Quantidade Produto
        public void RemoverProduto(int qtd)
        {
            Quant -= qtd;
        }

        //Método Adiciona Quantidade Produto
        public void AdicionarProduto(int qtd)
        {
            Quant += qtd;
        }

        //Método Override para ToString
        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quant +
                " unidades, Total: $ "
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
