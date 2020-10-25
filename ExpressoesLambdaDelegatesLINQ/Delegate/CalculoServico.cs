namespace ExpressoesLambdaDelegatesLINQ.Delegate
{
    //Classe Simples, com 2 Métodos recebendo 2 parâmetro
    //E 1 método recebendo 1 parâmetro
    class CalculoServico
    {
        //Método Nº Maio
        public static double Mair(double x, double y)
        {
            return (x > y) ? x : y;
        }

        //Método soma
        public static double Soma(double x, double y)
        {
            return x + y;
        }

        //Método Multiplica
        public static double Quadrado(double x)
        {
            return x * x;
        }
    }
}