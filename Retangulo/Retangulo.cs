using System;

namespace Primeiro
{
    //Classe para representar calculos de Retângulo
    class Retangulo
    {
        public double B; // Base Retângulo
        public double A; // Altura Retângulo

        //Método Calcula AREA A = B * A
        public double AreaTriangulo()
        {
            return B * A;
        }

        //Método Calcula PERIMETRO P = 2 * (B + A)
        public double PerimetroTriangulo()
        {
            return 2 * (B + A);
        }

        //Método Calcula DIAGONAL D = RAIZ² de(B² + A²) OU D² = B² + A²
        public double DiagonalTriangulo()
        {
            return Math.Sqrt(B * B + A * A);
        }
    }
}