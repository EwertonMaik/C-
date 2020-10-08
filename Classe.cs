using System;
using System.Globalization;

namespace Primeiro // Define que a Classe(Program) abaixo está organizada dentro do namespace(Primeiro) - Agrupa códigos do Projeto 
{
    class Program // Definição da Classe
    {
        static void Main(string[] args) // Declaração padrão do entry point, ponto de de entrada, inicio do programa
        {
            Console.WriteLine("Primeiro Programa C#"); //Método para imprimir valores escritos ou passado por variáveis ou parâmetros
            
            //Declaração de Váriaivies Locais
            sbyte  v_sbyte   = 126;         // até 127
            int    v_int     = 2147483647;  // até 2147483647
            byte   v_byte    = 255;         // até 255
            long   v_long    = 2147483648L;  //
            bool   v_bool    = true;         // aceita true ou false
            char   v_char    = 'M';          // aceita apenas um Caracter, Ex: 'M', 'F'
            char   v_char2   = '\u0041';     // outra forma de representar um valor caracter pelo seu código
            float  v_float   = 4.5F;
            double v_double  = 4.5;
            String v_string  = "Maria Green";
            Object v_object  = "João Brown";
            Object v_obj     = 4.5F;
            double v_double2 = 10.123456789;

            int v_int_m      = int.MinValue;  //Variáveil INT recebendo o Mínimo valor do Tipo INT
            Console.WriteLine(int.MaxValue);  //Imprimindo o valor máximo permitido no tipo de dados INT
            Console.WriteLine("Tipo Decimal - MIN {0} - MAX {1}", decimal.MinValue, decimal.MaxValue); //Imprimindo MIN e MAX do tipo Decimal
            Console.WriteLine("Tipo Double - MIN {0} - MAX {1}", double.MinValue, double.MaxValue); //Imprimindo MIN e MAX do tipo Double
            Console.WriteLine("Tipo Long - MIN {0} - MAX {1}", long.MinValue, long.MaxValue); //Imprimindo MIN e MAX do tipo Lon
            Console.WriteLine("Tipo sbyte - MIN {0} - MAX {1}", sbyte.MinValue, sbyte.MaxValue); //Imprimindo MIN e MAX do tipo sbyte
            Console.WriteLine("Tipo byte - MIN {0} - MAX {1}", byte.MinValue, byte.MaxValue); //Imprimindo MIN e MAX do tipo byte
            Console.WriteLine("Tipo Float - MIN {0} - MAX {1}", float.MinValue, float.MaxValue); //Imprimindo MIN e MAX tipo Float
            

            Console.WriteLine(v_double2.ToString("F3")); //Imprimindo e Delimitando uma váriavel tipo Double a 3 casas decimais
            Console.WriteLine(v_double2.ToString("F2", CultureInfo.InvariantCulture)); // Imprime o Nº Double com a formação de ponto
            Console.Write("Seja Bem Vindo!"); // Não tem quebra de Linhas
            Console.WriteLine(v_int_m);
            Console.WriteLine(v_object);
            Console.WriteLine(v_obj);
            Console.WriteLine(v_string);
            Console.WriteLine(v_sbyte);
            Console.WriteLine(v_int);
            Console.WriteLine(v_byte);
            Console.WriteLine(v_long);
            Console.WriteLine(v_bool);
            Console.WriteLine(v_char);
            Console.WriteLine(v_char2);
            Console.WriteLine(v_float);
            Console.WriteLine(v_double);

            int idade = 40;
            double saldo = 50.85901;
            string nome = "Pedro Silva";

            // Imprimindo valores via PLACEHOLDERS
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F3} reias", nome, idade, saldo);

            // Imprimindo valores via INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F3} reais");

            //Imprimindo valores via CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            //Operadore de Atibuição
            int var = 100;
            string v_text = "ABC";
            Console.WriteLine(var += 10); // var recebe var + 10
            Console.WriteLine(var -= 10); // var recebe var - 10
            Console.WriteLine(var *= 10); // var recebe var * 10
            Console.WriteLine(var /= 10); // var recebe var / 10
            Console.WriteLine(var %= 10); // var recebe var % 10 (Operador de Resto) var recebe o resto da divição entre 100/10 = 0
            Console.WriteLine(v_text += "DEFGH"); // v_text recebe v_text + "DEFGH"

            //Operadore Aritméticos de Atribuição
            int ope = 10;
            int v_rec;

            v_rec = ope++; // Variável v_rec recebe primeiro o valor de ope, e depois variável ope é incrementado + 1
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = ope--; // Variável v_rec recebe primeiro o valor de ope, e depois variável ope é decrementada - 1
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = ++ope; // Variável v_rec recebe o valor da variável ope já incrementada
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            v_rec = --ope; // Variável v_rec recebe o valor da variável ope já decrementada
            Console.WriteLine("valor v_rec - {0}, valor ope {1}", v_rec, ope);

            //Coversão Implicita entre Tipos - Double = 8 Bytes e o Float 4 Bytes
            float var_float   = 4.98F;
            double var_double3 = var_float; // O tipo Double é maior e aceita conversão implicita de um tipo menor, como tipo Float
            Console.WriteLine(var_double3);

            //Conversão Explicita
            //Double = 8 Bytes e o Float 4 Bytes, para jogar o valor de uma var Double em uma var Float, é preciso realizar um CAST,
            // Isso pode gerar peda de dados
            float  var_float2;
            int var_int;
            double var_double4 = 8.57;

            var_float2 = (float)var_double4; //Variável Float tamanho 4 bits recebendo o valor de uma  variável Double 8 bits, via CAST
            Console.WriteLine(var_float2);

            var_int = (int)var_double4; //Variável Int tamanho 4 bits que não tem por sinal valor quebrado, recebendo variável Double 8 bits, via CAST
            Console.WriteLine(var_int);

            //Uma variável Double recebendo a valor de uma divisão entre inteiros, o resultado é um INTEIRO
            var_int = 100;
            double resultado = var_int / 3;
            Console.WriteLine(resultado);

            //Uma variável Double recebendo o valor de uma divisão entre inteiros com um CAST, se a divisão tiver valores quebrados,
            //Devido ao CAST o valor correspondente será salvo sem perda de dados 
            resultado = (double)var_int / 3;
            Console.WriteLine(resultado);

            //Aplicando Exemplo de Calculo de Bhaskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta;
            double x1, x2;

            delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            Console.WriteLine("Valor de Delta é: {0}", delta);

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Valor de X1 é: {0}", x1);

            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Valor de x2 é: {0}", x2);

            //Entrada de Dados com Console.ReadLine();
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //string s = Console.ReadLine();
            //string[] vetor = s.Split(' '); //Função de String Split - quebra a String onde tem espaço e armazena em cada pocisão do vetor

            Console.WriteLine(" Entre com 3 valores: ");
            string[]  vetor = Console.ReadLine().Split(' '); //Lendo e já aplicando o split e salvando em cada posição do vetor
            string a1 = vetor[0];
            string b1 = vetor[1];
            string c1 = vetor[2];

            Console.WriteLine("Você digitou : ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a1);
            Console.WriteLine(b1);
            Console.WriteLine(c1);

            //Entrada de dados String e convertendo para outros tipos de dados
            int n1 = int.Parse( Console.ReadLine() );
            char n2 = char.Parse( Console.ReadLine() );
            double n3 = double.Parse( Console.ReadLine() );
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture ); //caso deseje usar o padrão de nº com (.) e não (,)

            string[] vet2 = Console.ReadLine().Split(' ');
            string nome1 = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade1 = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você Digitou : ");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4.ToString("F3"), CultureInfo.InvariantCulture);

            Console.WriteLine(nome1);
            Console.WriteLine(sexo);
            Console.WriteLine(idade1);
            Console.WriteLine(altura);
            Console.WriteLine(altura.ToString("F3", CultureInfo.InvariantCulture) );

            //Cálculo de Área
            Console.WriteLine("Cálculo de Área =>>>>");
            double PI = 3.14159;
            Console.WriteLine("Valor de PI é: {0} ", PI);
            Console.WriteLine("Digite o valor do Raio: ");
            double raio = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture );
            double area = PI * ( raio * raio );
            Console.WriteLine("A área é: {0}", area.ToString("F4", CultureInfo.InvariantCulture) );

            //Operadores Comparativos
            // > MAIOR
            // < MENOR
            // >= MAIOR e IGUAL
            // <= MENOR e IGUAL
            // == IGUAL
            // != DIFERENTE

            //Operadores Lógicos
            // && - E
            // || - OU
            //  ! - NÂO

            //Estrutura Condicional IF ELSE
            //SIMPLES
            Console.WriteLine("Estrutura SIMPLES - Digite um Número: ");
            int v_01 = int.Parse(Console.ReadLine() );
            if (v_01 > 10)
            {
                Console.WriteLine("O valor digitado é maior que 10!");
            }

            //COMPOSTA
            Console.WriteLine("Estrutura COMPOSTA - Digite Número Inteiro: ");
            int v_par_impar = int.Parse(Console.ReadLine());

            if (v_par_impar % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é impar");
            }

            //ENCADEADA
            Console.WriteLine("Estrutura ENCADEADA - Digite que horas são!");
            int v_horas = int.Parse(Console.ReadLine() );

            if (v_horas < 12)
            {
                Console.WriteLine("Bom dia! é {0} horas da manhã!", v_horas);
            }
            else if (v_horas < 18)
            {
                Console.WriteLine("Boa tarde! é {0} horas da tarde!", v_horas);
            }
            else
            {
                Console.WriteLine("Boa noite! é {0} horas da noite!", v_horas);
            }

            //Escopo de uma Váriável
            int v_escopo; // Variável Declara, porém não inicializada
            v_escopo = 10; // Variável inicializada, atribuido valor manualmente
            v_escopo = int.Parse(Console.ReadLine() ); // Variável irá receber valor via entrada de dados em tela
            Console.WriteLine("Valor Variável é {0} : ", v_escopo); // Variável sendo impressa em tela
            // Uma váriável declarda dentro de um escopo menor Ex: Estrutura de While, If, For, função etc.
            // Sua variável so pode ser usada dentro dela, não fica disponivel para um escopo maior como o bloco da estrutura Main

            

            //Executando uma função criada fora do método MAIN
            Console.WriteLine("Digite 3 Numeros: ");
            int num1 = int.Parse(Console.ReadLine() );
            int num2 = int.Parse(Console.ReadLine() );
            int num3 = int.Parse(Console.ReadLine() );

            int num_maior = FuncaoMaior(num1, num2, num3);
            Console.WriteLine("O maior número é: {0}", num_maior);

            //Debugging com Visual Studio
            // F9 - Marcar / Desmarcar BreakPoint
            // F5 - Iniciar / Continuar o Debug
            // F10 - Executar um passo (pula função)
            // F11 - Executar um passo (entra na função)
            // SHIFT + F11 - Sair método em execução
            // SHIFT + F5  - Parar Debug

            
            //Estrutura Condicional WHILE
            Console.Write("Digite um Número: ");
            double v_while = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (v_while >= 0.0)
            {
                double v_raiz = Math.Sqrt(v_while);
                Console.WriteLine(v_raiz.ToString("F2"), CultureInfo.InvariantCulture);
                Console.Write("Digite outro Número: ");
                v_while = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Programa Encerrado - Número Negativo");

            //Estrutura de Controle FOR
            Console.Write("Quantos Nº deseja Somar : ");
            int v_for = int.Parse(Console.ReadLine() );

            int soma = 0;
            for (int i = 1; i <= v_for; i++)
            {
                Console.Write("Digite {0}ª Nª : ", i);
                int valor = int.Parse(Console.ReadLine() );
                soma += valor;
            }
            Console.WriteLine("Total soma nº digitados: {0}", soma);


        }//Fim do método MAIN

        static int FuncaoMaior(int p1, int p2, int p3) // Função recebe 3 valore e calcula qual é o maior
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
        }

    }
}
