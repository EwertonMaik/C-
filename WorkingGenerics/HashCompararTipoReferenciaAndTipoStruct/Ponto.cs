namespace WorkingGenerics.HashCompararTipoReferenciaAndTipoStruct
{
    //Tipo Struct - representa a comparação por valor da variávçel
    struct Ponto
    {
        //Atributos AutoProperties
        public int x { get; set; }
        public int y { get; set; }

        //Construtor
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}