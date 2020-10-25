namespace ExpressoesLambdaDelegatesLINQ.Linq.Caso02DiversasOperacoes
{
    //Classe Entidade Produtos
    class Produto
    {
        //Atributos AutoProperties
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }

        //Método Override ToString
        public override string ToString()
        {
            return "ID - " + Id + " Nome - " + Nome + " Preço - " + Preco + " Categoria - "
                + Categoria.Nome + " Nivel - " + Categoria.Nivel;
        }
    }
}