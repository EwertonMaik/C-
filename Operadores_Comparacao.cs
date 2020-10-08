using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Operadores_Comparacao // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Operadores Comparativos
            // > MAIOR
            // < MENOR
            // >= MAIOR OU IGUAL
            // <= MENOR OU IGUAL
            // == IGUAL
            // != DIFERENTE
            
            int  n1 = 10;
            int  n2 = 20;
            
            bool r = n1 > n2;
            Console.WriteLine("N1 {0} é > N2 {1}? : {2}", n1, n2, r); //Recebe False
            r = n1 < n2;
            Console.WriteLine("N1 {0} é < N2 {1}? : {2}", n1, n2, r); //Recebe True
            r = n1 >= n2;
            Console.WriteLine("N1 {0} é >= N2 {1}? : {2}", n1, n2, r); //Recebe False
            r = n1 <= n2;
            Console.WriteLine("N1 {0} é <= N2 {1}? : {2}", n1, n2, r); //Recebe True
            r = n1 == n2;
            Console.WriteLine("N1 {0} é == N2 {1}? : {2}", n1, n2, r); //Recebe False
            r = n1 != n2;
            Console.WriteLine("N1 {0} é != N2 {1}? : {2}", n1, n2, r); //Recebe True
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
