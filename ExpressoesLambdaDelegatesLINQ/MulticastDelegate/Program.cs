namespace ExpressoesLambdaDelegatesLINQ.MulticastDelegate
{
    //Classe Principal
    class Program
    {
        //Declarando Delegate - Como void
        delegate void OperacaoNumerica(double n1, double n2);

        //Método Main
        static void Main(string[] args)
        {
            //Declaração Atributos
            double a = 10;
            double b = 20;

            //Instânciando Delegate - Recebendo referência de mais de 1 método
            OperacaoNumerica ope = Calculo.Maior;
            ope += Calculo.Soma;

            //Os 2 métodos seram executados
            ope(a, b);
            //ou
            ope.Invoke(a, b);
        }
    }
}