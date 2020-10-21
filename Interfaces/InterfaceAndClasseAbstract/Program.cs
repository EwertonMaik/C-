using System;
using WorkingInterfaces.InterfaceAndClasseAbstract.Entities;
using WorkingInterfaces.InterfaceAndClasseAbstract.Enum;

namespace WorkingInterfaces.InterfaceAndClasseAbstract
{
    //Classe com Método Principal
    class Program
    {
        //Main
        static void Main(string[] args)
        {
            //Declarando 2 váriaveis do Tipo Interface
            //Recebendo Classes que Herdam da Classe AbstractForma, e que Implementa Interface de IForma
            IForma interfaceCirculo = new Circulo() { Raio = 10.0, cor = Cor.Branco};
            IForma interfaceRetangulo = new Retangulo() { Largura = 5.0, Altura = 10.0, cor = Cor.Preto };

            Console.WriteLine(interfaceCirculo);
            Console.WriteLine(interfaceRetangulo);
        }
    }
}