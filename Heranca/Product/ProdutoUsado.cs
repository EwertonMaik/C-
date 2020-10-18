using System;
using System.Text;

namespace ProjectHerancaPolimorfismo.Product
{
    //Classe PprodutoUsado, Herdando de Produto
    class ProdutoUsado : Produto
    {
        //Declarando Atributos
        public DateTime DataFabricacao { get; set; }

        //Construtores
        public ProdutoUsado()
        {
        }

        //Chamando o Contrutor da Classe Base Produto
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao)
            : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        //Método sobrescrito da classe Produto
        public override string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome Produto (USADO): {Nome}  - Preço Produto : R$ {Preco}  - Data Fabricação {DataFabricacao.ToString("dd/MM/yyyy") }" );
            return sb.ToString();
        }
    }
}