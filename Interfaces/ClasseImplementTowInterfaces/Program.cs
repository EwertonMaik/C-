using System;

namespace WorkingInterfaces.ClasseImplementTowInterfaces
{
    //Classe principal
    class Program
    {
        //Método main
        static void Main(string[] args)
        {
            /*
             Uma classe chamada ComboDispositivos, não consegue realizar herança multipla das classes
             (Scanner e Impressora), devido essas duas classes terem como herança de sua Classe Pai (Dispositivos),
             Logo, o CLR não permitirá, essa herança multipla, pois terá métodos ambíguos sobrescritos da classe PAI.

             O problema de Herança Multipla ou Diamante, que o CLR não permite, pode ser implementada de outra forma usando Interfaces. 
             */

            Console.WriteLine("*** IMPRESSORA - Classe Dispositivos / Interface IImpressora ***");
            Impressora imp = new Impressora() { NumeroSerial = 1000 };
            imp.ProcessaDoc("Método Implementado da Classe Abstrata Dispositivos");
            imp.Imprimir("Método Implementado da Interface IImpressoras");

            Console.WriteLine("*** SCANNER - Classe Dispositivos / Interface IScanner ***");
            Scanner scan = new Scanner() { NumeroSerial = 2000 };
            scan.ProcessaDoc("Método Implementado da Classe Abstrata Dispositivos");
            Console.WriteLine(scan.Scan() ); //Método Implementado da Interface IScanner

            Console.WriteLine("*** COMBODISPOSITIVOS - Classe Dispositivos / Interface (IImpressora - IScanner) ***");
            ComboDispositivos cd = new ComboDispositivos() { NumeroSerial = 3000 };
            cd.ProcessaDoc("Método Implementado da Classe Abstrata Dispositivos");
            cd.Imprimir("Método Implementado da Interface IImpressoras");
            Console.WriteLine(cd.Scan() ); ////Método Implementado da Interface IScanner

        }
    }
}
