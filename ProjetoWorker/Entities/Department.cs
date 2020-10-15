namespace ProjetoWorker.Entities
{
    //Classe  - entidade de Departamentos
    class Department
    {
        //Declaração usando AutoProperties
        public string Nome { get; set; }


        //Definindo Alguns Construtores
        public Department()
        {
        }

        public Department(string nome)
        {
            Nome = nome;
        }
    }
}