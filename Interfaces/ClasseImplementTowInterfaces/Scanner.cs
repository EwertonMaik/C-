using System;

namespace WorkingInterfaces.ClasseImplementTowInterfaces
{
    //Classe Scanner Herda da Classe Dispositivos e implementa Interface IScanner
    class Scanner : Dispositivos, IScanner
    {
        //Método Implementado da Classe Abstrata Dispositivos
        public override void ProcessaDoc(string doc)
        {
            Console.WriteLine("Classe Scanner - Dispositivos - ProcessaDoc : " + doc); ;
        }

        //Método Implementado da Interface IScanner
        public string Scan()
        {
            return "Classe Scanner - Interface IScanner - Scan";
        }
    }
}