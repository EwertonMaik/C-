using System.Globalization;
using System.Text;

namespace ProjectHerancaPolimorfismo.Product
{
    //Classe entidade ProdutoImportado herdando de Produto
    class ProdutoImportado : Produto
    {
        //Declaração de Atributo
        public double TaxaAlfandega { get; set; }

        //Construtores
        public ProdutoImportado()
        {
        }

        //Chamando Construtor da Classe Produto
        public ProdutoImportado(string nome, double preco, double taxaAlfandega)
            : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        //Método para calcular o Preço Total
        public double PrecoTotal ()
        {
            return TaxaAlfandega + Preco;
        }

        //Método sobrescrito da classe Produto
        public override string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome Produto (IMPORTADO): {Nome}  - Preço Produto : R$ {Preco}  - Taxa Alfandega : R$ {TaxaAlfandega}  - Preço Total : R$ {PrecoTotal().ToString("F2" , CultureInfo.InvariantCulture) }");
            return sb.ToString();
        }
    }
}