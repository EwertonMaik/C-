using WorkingInterfaces.InterfaceAndClasseAbstract.Enum;

namespace WorkingInterfaces.InterfaceAndClasseAbstract.Entities
{
    //Classe AbstractForma que implmenta a Interface IForma
    abstract class AbstractForma : IForma
    {
        //Atributo
        public Cor cor { get; set; }

        public abstract double Area();
    }
}