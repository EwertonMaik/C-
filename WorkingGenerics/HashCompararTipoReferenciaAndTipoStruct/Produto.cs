namespace WorkingGenerics.HashCompararTipoReferenciaAndTipoStruct
{
    //Classe Entidade - Representa Referência ao ser comparado na Memória
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
        /* REMOVA O COMENTÁRIO, E A COMPARAÇÃO DO TIPO REFERÊNCIA EM PROGRAM, RETORNARÁ TRUE
        //Implementando Método Equals
        public override bool Equals(object obj)
        {
            if (! (obj is Produto) )
            {
                return false;
            }
            Produto prod = obj as Produto;

            return Nome.Equals(prod.Nome) && Preco.Equals(prod.Preco);
        }

        //Implementando Método GetHashCode
        public override int GetHashCode()
        {
            return Nome.GetHashCode() + Preco.GetHashCode();
        }
        */
    }
}