namespace ProjectHerancaPolimorfismo.ClasseMetodoAbstract
{
    //Classe entidade, Genérica e Abstrata, não pode ser instãnciada
    //Seus métodos são Abstratos também
    abstract class Figura
    {
        //Declaração de Atributo com AutoProperties
        public Cor Cor { get; set; }

        //Construtores
        public Figura(Cor cor)
        {
            Cor = cor;
        }

        //Método Abstract, não pode ser implementado, e é sobrescrito nas SubClasses
        public abstract double Area();

    }
}