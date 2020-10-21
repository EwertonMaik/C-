namespace WorkingInterfaces.SemInterfaces.Entities
{
    //Classe entidade - Veiculo
    class Veiculo
    {
        //Atributos via AutoProperties
        public string Modelo { get; set; }

        //Construtor
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}