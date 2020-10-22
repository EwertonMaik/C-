using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingGenerics.GetEqualsAndGetHashCode
{
    //Classe Entidade Cliente, para implementar método sobrescrito de equals e hashcode
    class Cliente
    {
        //Atributos AutoProperties
        public string Nome { get; set; }
        public string Email { get; set; }

        //Implementando GetEquals
        public override bool Equals(object obj)
        {
            if (! (obj is Cliente))
            {
                throw new ArgumentException("Erro ArgumentException - Não é um Cliente!");
            }

            Cliente cli = obj as Cliente;
            return Email.Equals(cli.Email);
        }

        //Método GetHashCode
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}