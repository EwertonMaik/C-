using System;

namespace Primeiro
{
    class CalcCirculo
    {
        public static double PI = 3.14159;

        //Método Estático para Cálcular Circunferencia CIRCULO
        //Formula C = 2 * PI * R ou C = D * PI
        public static double CircunferenciaC(double r)
        {
            return 2.0 * PI * r;
        }

        //Método Estático para Cálcular Volume
        public static double VolumeC(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }

        //Método Estático para Cálcular Área CIRCULO
        // A = PI * R² OU A = (PI * D²) / 4
        public static double AreaC(double r)
        {
            return PI * (r * r);
        }

        //Método Estático para Cálcular Diâmetro CIRCULO
        // D = 2 * R
        public static double DiametroC(double r)
        {
            return 2 * r;
        }

        //Método Estático para Cálcular o Raio CIRCULO
        // R = D / 2
        public static double RaioC(double d)
        {
            return d / 2;
        }

    }
}