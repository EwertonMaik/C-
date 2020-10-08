using System; //NameSpace da Linguagem que contêm diversas classes e métodos

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Estrutura_For // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            //Estrutura de Controle FOR
            Console.Write("Quantos Nº deseja Somar : ");
            int v_for = int.Parse(Console.ReadLine() );

            int soma = 0;
            //Base na variável v_for vai executar de 1 até v_for, e somar os números digitados
            for (int i = 1; i <= v_for; i++) // INICIO / CONDIÇÃO / INCREMENTO
            {
                Console.Write("Digite {0}ª Nª : ", i);
                int valor = int.Parse(Console.ReadLine() );
                soma += valor;
            }
            Console.WriteLine("Total soma nº digitados: {0}", soma);
            
        }//Fim do método MAIN

    }//Fim da Classe Program

}//Fim Namespace
