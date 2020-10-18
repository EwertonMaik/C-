namespace ProjectHerancaPolimorfismo.ClasseMetodoAbstract
{
    //Classe Entidade - Herda da Classe Abstract Figura
    //Retangulo pode ser Abstract ou obrigatoriamente ter que implmentar dos métodos abstracts da Classe Figura
    class Retangulo : Figura
    {
        //Declaração de Atributos AutoProperties
        public double Largura { get; set; }
        public double Altura { get; set; }

        //Construtor Retangulo + Construtor Figura
        public Retangulo(double largura, double altura, Cor cor)
            : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        //Método Area Sobreposto da Classe Abstract Figura
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}