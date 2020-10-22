using System;

namespace WorkingInterfaces.ClasseImplementTowInterfaces
{
    //Classe Impressora Herda da Classe Dispositivos e implementa Interface IImpressora
    class Impressora : Dispositivos, IImpressora
    {
        //Método Implementado da Classe Abstrata Dispositivos
        public override void ProcessaDoc(string doc)
        {
            Console.WriteLine("Classe Impressora - Dispositivos - ProcessaDoc : " + doc);
        }

        //Método Implementado da Interface IImpressoras
        public void Imprimir(string doc)
        {
            Console.WriteLine("Classe Impressora - Interface IImpressora - Imprimir : " + doc);
        }
    }
}