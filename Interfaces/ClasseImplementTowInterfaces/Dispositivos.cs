namespace WorkingInterfaces.ClasseImplementTowInterfaces
{
    //Classe Genérica, será usada como Herança pela classe Scanner e Impressora
    abstract class Dispositivos
    {
        //Atributo AutoProperties
        public int NumeroSerial { get; set; }

        //Método a ser
        public abstract void ProcessaDoc(string doc);
    }
}