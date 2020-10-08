using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Criando_Funcao_Classe // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //FuncaoMaior é uma função criada fora do método Main que recebe como parâmetro 3 valores INT e calcula e retorna qual é o maior Número INT
            int num_maior = FuncaoMaior(num1, num2, num3); //Variável recebe o maior número passado para a Função
            Console.WriteLine("O maior número é: {0}", num_maior);
            
        }//Fim do método MAIN
    }//Fim da Classe Program
    
    // Função FuncaoMaior recebe 3 valores, calcula e retorna qual é o maior
    static int FuncaoMaior(int p1, int p2, int p3)
        {
            int resul;
            if (p1 > p2 && p1 > p3)
            {
                resul = p1;
            }
            else if (p2 > p3)
            {
                resul = p2;
            }
            else
            {
                resul = p3;
            }
            return resul;
        }//FIm Função

}//Fim Namespace
