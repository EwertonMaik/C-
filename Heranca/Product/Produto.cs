using System.Text;

namespace ProjectHerancaPolimorfismo.Product
{
    //Classe entidade - Produto, Contêm atributos e metodos padrão para Produtos Usados e Importados
    class Produto
    {
        //Declaração de Atributos AutoProperties
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtores
        public Produto()
        {
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Método que poderá ser sobrescrito por Produtos Usados e Importados
        public virtual string EtiquetaPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome Produto : {Nome}  - Preço Produto : R$ {Preco}");
            return sb.ToString();
        }
    }
}