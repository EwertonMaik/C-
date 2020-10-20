using System;

namespace EstruturaException
{
    //Classe Programa Principal
    class TryCatch
    {
        //Método Main
        static void Main(string[] args)
        {

            //Estrutura do Bloco Try-Catch
            try
            {
                //Declaração e Entrada de Dados Convertidos para INT
                //Caso seje Letra, ou divisão por 0, o erro será capturado no CATCH
                Console.WriteLine("Digite 2 Nº : ");
                int t01 = int.Parse(Console.ReadLine());
                int t02 = int.Parse(Console.ReadLine());

                int resp = t01 / t02;
                Console.WriteLine(resp);
            }
            catch (DivideByZeroException d) //Usando a SubClasse DivideByZeroException de Exception
            {
                Console.WriteLine("Erro DivideByZeroException : " + d.Message);
            }
            catch (FormatException f) //Usando a SubClasse FormatException de Exception
            {
                Console.WriteLine("Erro FormatException : " + f.Message);
            }
            catch (Exception e) //Usando a classe Genérica que irá capiturar todo tipo de Exceção
            {
                Console.WriteLine("Erro Exception : " + e.Message);
            }
        }
    }
}
