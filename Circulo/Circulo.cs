using System;

namespace Primeiro
{
    //Classe Circulo para representar Calculos de Circulo
    //Usando Membros Estáticos, podem ser chamados pelo próprio nome e não precisa instânciar
    class Circulo
    {
        public static void Main(String[] args)
        {
            Console.Write("Entre com o valor Raio para Cálcular Circunferência: ");
            double raio = double.Parse(Console.ReadLine() );

            Console.WriteLine("Circunferência é : {0}", CalcCirculo. CircunferenciaC(raio) );
            Console.WriteLine("Volume é: {0}", CalcCirculo.VolumeC(raio) );
            Console.WriteLine("Área é: {0}", CalcCirculo.AreaC(raio) );
            Console.WriteLine("Diametro é: {0}", CalcCirculo.DiametroC(raio) );

            Console.WriteLine("Entre com o Diametro de um Circulo: ");
            double diam = double.Parse(Console.ReadLine() );
            Console.WriteLine("Raio é: {0}", CalcCirculo.RaioC(diam) );
        }
    }
}