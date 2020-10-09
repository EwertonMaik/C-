using System;

namespace Primeiro
{
    //Classe para representar a estrutura de um Triângulo
    class Triangulo
    {
        //Variáveis publicas da Classe
        public double A;
        public double B;
        public double C;
        
        // Função para Calcular o Perimetro e Área
        public double Fun_Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C) );
        }
    }
}
