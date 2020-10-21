namespace WorkingWithFile.ProductCsv
{
    //Classe Entidade Para Produtos
    class Product
    {
        //Declaração de Atributos
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        //Construtor
        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Método para calcular Valor Total Produto
        public double Total()
        {
            return Preco * Quantidade;
        }
    }
}