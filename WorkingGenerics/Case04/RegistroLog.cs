using System;

namespace WorkingGenerics.Case04
{
    //Classe Entidade - Resgitro Log - Representa os atributos de um arquivo de log externo que será lido
    class RegistroLog
    {
        //Atributos AutoProperties
        public string Nome { get; set; }
        public DateTime DataHora { get; set; }

        //Método Construtor
        public RegistroLog(string nome, DateTime dataHora)
        {
            Nome = nome;
            DataHora = dataHora;
        }

        //Implementado Método GetHashCode
        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        //Implementado Método Equals - Permeritá que na comparação da lista HashSet, não seja adicionado valor repetido
        public override bool Equals(object obj)
        {
            if (!(obj is RegistroLog)) // Retorna falso caso parâmetro recebido não seja RegistroLog
            {
                return false;
            }
            RegistroLog other = obj as RegistroLog; //DownCasting
            return Nome.Equals(other.Nome); //Realiza a comparação
        }
    }
}