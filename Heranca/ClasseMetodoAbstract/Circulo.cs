using System;

namespace ProjectHerancaPolimorfismo.ClasseMetodoAbstract
{
    //Classe Entidade - Herda da Classe Abstract Figura
    //Circulo pode ser Abstract ou obrigatoriamente ter que implmentar dos métodos abstracts da Classe Figura
    class Circulo : Figura
    {
        //Declaração Atributo AutoProperties
        public double Raio { get; set; }

        //Construtor
        public Circulo(double raio, Cor cor)
            : base(cor)
        {
            Raio = raio;
        }

        //Método Area Sobreposto da Classe Abstract Figura
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}