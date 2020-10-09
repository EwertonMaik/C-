using System;
using System.Globalization;

namespace Primeiro
{
    //Classe para representar estrutura e métodos de Produto
    class Produto
    {
        public string Nome;
        public double Preco;
        public int    Quant;

        //Método Construtor
        //É executado quando uma classe é Instânciada
        //Quando a classe for instãnciada poderá ser passado os valore por parâmetro
        public Produto(string nome, double preco, int quant)
        {
            Nome = nome;
            Preco = preco;
            Quant = quant;
        }
        
        //Sobrecarga do Método Construtor
        //Com isso a classe Produto pode ser Instânciada sem ter que passar parâmetros como o método anterior
        public Produto(){
        }
        
        //Método Construtor com utilização da palavra reservada (THIS)
        //Que referencia a variável da Classe e não a local do método
        public Produto(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

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
