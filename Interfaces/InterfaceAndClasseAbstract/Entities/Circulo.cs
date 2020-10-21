using System;
using System.Globalization;

namespace WorkingInterfaces.InterfaceAndClasseAbstract.Entities
{
    //Classe Circulo Herda da Classe AbstractForma
    class Circulo : AbstractForma
    {
        //Atributo
        public double Raio { get; set; }

        //Método Sobreposto Implementada da Classe AbstractForma
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }

        //Sobrepondo Método ToString()
        public override string ToString()
        {
            return "Cor Circulo = "
                + cor
                + ", Raio = "
                + Raio.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}