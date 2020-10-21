using System.Globalization;

namespace WorkingInterfaces.InterfaceAndClasseAbstract.Entities
{
    //Classe Entidade Retangulo Herda Classe AbstractForma
    class Retangulo : AbstractForma
    {
        //Atributos AutoProperties
        public double Largura { get; set; }
        public double Altura { get; set; }

        //Método Sobreposto Implementada da Classe AbstractForma
        public override double Area()
        {
            return Largura * Altura;
        }

        //Sobrepondo Método ToString()
        public override string ToString()
        {
            return "Cor Retângulo = "
                + cor
                + ", Largura = "
                + Largura.ToString("F2", CultureInfo.InvariantCulture)
                + ", Altura = "
                + Altura.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}