namespace ExpressoesLambdaDelegatesLINQ.PredicateAction
{
    //Classe Entidade Produto
    class Produto
    {
        //Atributos AutoProperties
        public string Nome { get; set; }
        public double Preco { get; set; }

        //Construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Método override ToString
        public override string ToString()
        {
            return "Nome - " + Nome + " / Preço - " + Preco;
        }
    }
}