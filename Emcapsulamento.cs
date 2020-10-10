using System;

namespace Primeiro
{
    //Classe para Exemplo de encapsulamento
    class Emcapsulamento
    {
        //Definindo atributos private
        private string  _nome;
        private int     _idade;
        private string  _depart;

        //Método Construtor
        public Emcapsulamento()
        {
        }

        //Métodos Get e Set, forma para se ter acesso aos atributos
        public string GetNome ()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
            
        }
        public int GetIdade()
        {
            return _idade;
        }
        public void SetIdade(int idade)
        {
            if (idade != 0 && idade > 0)
            {
                _idade = idade;
            }
        }
        public string GetDepart()
        {
            return _depart;
        }
        public void SetDepart(string depart)
        {
            if (depart != null && depart.Length > 1)
            {
                _depart = depart;
            }
        }

        //Método main dentro da própria Classe, poderia ser em outra classe também
        public void Main(string[] args)
        {
            //Classe instânciada
            Emcapsulamento emcap = new Emcapsulamento();

            //Não se tem mais acesso aos atributos da classe direto
            //Acesso somente via os métodos de acesso Get e Set
            emcap.SetNome("Maria Silva");
            Console.WriteLine(emcap.GetNome() );
            emcap.SetIdade(30);
            Console.WriteLine(emcap.GetIdade() );
            emcap.SetDepart("TI");
            Console.WriteLine(emcap.GetDepart() );
        }

    }
}