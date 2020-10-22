using System;

namespace WorkingInterfaces.ClasseImplementTowInterfaces
{
    //Classe ComboDispositivos, Herda da classe Dispositivos e de 2 Interfaces IImpressora / IScanner
    class ComboDispositivos : Dispositivos, IImpressora, IScanner
    {
        //Método Implementado da Classe Abstrata Dispositivos
        public override void ProcessaDoc(string doc)
        {
            Console.WriteLine("Classe ComboDispositivos - Dispositivos - ProcessaDoc : " + doc);
        }

        //Método Implementado da Interface IImpressoras
        public void Imprimir(string doc)
        {
            Console.WriteLine("Classe ComboDispositivos - Interface IImpressora - Imprimir : " + doc);
        }

        //Método Implementado da Interface IScanner
        public string Scan()
        {
            return "Classe ComboDispositivos - Interface IScanner - Scan";
        }
    }
}