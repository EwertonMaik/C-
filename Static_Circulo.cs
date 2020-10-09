using System;

namespace Primeiro
{
    //Classe Circulo para representar Calculos de Circulo
    //Usando Membros Estáticos, podem ser chamados pelo próprio nome e não precisa instânciar
    class Circulo
    {
        static double PI = 3.14159;

        public static void Main(String[] args)
        {
            Console.Write("Entre com o valor Raio para Cálcular Circunferência: ");
            double raio = double.Parse(Console.ReadLine() );

            Console.WriteLine("Circunferência é : {0}", CircunferenciaC(raio) );
            Console.WriteLine("Volume é: {0}", VolumeC(raio) );
            Console.WriteLine("Área é: {0}", AreaC(raio) );
            Console.WriteLine("Diametro é: {0}", DiametroC(raio) );

            Console.WriteLine("Entre com o Diametro de um Circulo: ");
            double diam = double.Parse(Console.ReadLine() );
            Console.WriteLine("Raio é: {0}", RaioC(diam) );
        }

        //Método Estático para Cálcular Circunferencia CIRCULO
        //Formula C = 2 * PI * R ou C = D * PI
        static double CircunferenciaC(double r)
        {
            return 2.0 * PI * r;
        }

        //Método Estático para Cálcular Volume
        static double VolumeC(double r)
        {
            return 4.0 / 3.0 * PI * r * r * r;
        }

        //Método Estático para Cálcular Área CIRCULO
        // A = PI * R² OU A = (PI * D²) / 4
        static double AreaC(double r)
        {
            return PI * (r * r);
        }

        //Método Estático para Cálcular Diâmetro CIRCULO
        // D = 2 * R
        static double DiametroC(double r)
        {
            return 2 * r;
        }

        //Método Estático para Cálcular o Raio CIRCULO
        // R = D / 2
        static double RaioC(double d)
        {
            return d / 2;
        }
    }
}
