using System;

namespace WorkingGenerics.Caso02ComObject
{
    //Classe entidade contêm os serviços de impressão
    //Seus atributos são do Tipo Object, podendo receber qualquer valor de entrada
    class ServicoImpressao
    {
        //Atributos
        private object[] _valores = new object[10];
        private int _count = 0; //Para controlar as posições

        //Método para Adicionar valores ao Vetor
        public void AdicionarValores(object valor)
        {
            if (_count == 10 ) ///Lança exceção de erro caso esteja cheio
            {
                throw new InvalidOperationException("InvalidOperationException - Vetor está cheio!");
            }
            _valores[_count] = valor;
            _count++;
        }

        //Método para retornar o primeiro elemento do Vetor
        public object PrimeiroValor()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("InvalidOperationException - Vetor é Vazio ainda!");
            }
            return _valores[0];
        }

        //Método para imprimir valor
        public void Imprimir()
        {
            Console.Write("[");
            for (int i = 0; i < _count -1; i++) //Imprime da Posição 0 a penultima
            {
                Console.Write(_valores[i] + ", ");
            }
            if (_count > 0) //Imprime a Última posição com valor
            {
                Console.Write(_valores[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}