namespace ExpressoesLambdaDelegatesLINQ.Linq.Caso04
{
    //Classe Entidade de Produtos
    class Produto
    {
        //Atributos AutoProperties
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Método Construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}