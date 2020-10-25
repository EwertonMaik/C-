# ❤️ Linguagem de Programação C#

* Usando Visual Studio 2019 / .NET Framework e .NET CORE
* Debugging com Visual Studio
* F9 - Marcar / Desmarcar BreakPoint
* F5 - Iniciar / Continuar o Debug
* F10 - Executar um passo (pula função)
* F11 - Executar um passo (entra na função)
* SHIFT + F11 - Sair método em execução
* SHIFT + F5  - Parar Debug

Este repositório contêm alguns exemplos práticos e projetos em desenvolvimentos da Linguagem C# usando;
Classes, Atributos, Encapsulamento, Construtores, Estruturas IF ElSE - Simples, Composta, Encadeada e Ternário. Estrutura For, Foreach,
Estrutura While, Métodos, Sobrecarga, Métodos, Construtores, Herança, Polimorfismo entre outros recursos.
Uso de this para diferênciar atributos de variáveis locais. Nullable, Vetores, Matrizes, Listas, Modificador Params, Ref e Out.
Enum, Boxing e Unboxing, composição, Upcasting, Downcasting.

# ✔️ Tipo de Dados Referência e Tipo Valor/Struct.
Classe - Vantagem: usa todos recursos OO), Variáveis são ponteiros, precisa ser instânciada new, aceita valor null, suporta herança, y = x (y recebe o ponteiro de x), objetos instânciados do heap, objetos não utilizados são desalocados em um momento próximo pelo Garbage Collector.

Struct - Struct (É mais simples e performático, variáveis são caixa, não é preciso instânciar, mais é possível, não aceita null, não tem suporte a herança, aceita interfaces, y = x (recebe uma cópia de x), objetos instanciados no stack, objetos são desalocados imediatamente quando seu escopo de execução é finalizado ).

# ✔️ Memória - Stack e Heap
Garbage Collector - Processo que gerencia memória de um programa. Monitora objetos dinamicamente no heap, desalocando os que não estão sendo mais usados.

Desalocação por Escopo - O que é alocado dentro de um método é desalocado assim que a execução sair do escopo.
Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução.

# ✔️ Valores Padrão tipo de dados Classe, Struct, Arrays
Números = 0;
bool = false;
char = caractere código 0;
objeto = null;

# ✔️ Ordem de Construção de uma Classe

* Atributos privados
* Propriedades autoimplementadas
* Construtores
* Propriedades Customizadas
* Outros Métodos da classe

# ✔️ Modificadores de Acesso para Membro de uma Classe

* 1 - public (própria classe / subclasses no assembly / classes do assembly / subclasses fora do assembly / classes fora do assembly)
* 2 - protected internal (própria classe / subclasses no assembly / classes do assembly / subclasses fora do assembly)
* 3 - internal (própria classe / subclasses no assembly / classes do assembly)
* 4 - protected (própria classe / subclasses no assembly / subclasses fora do assembly)
* 5 - private protected (própria classe / subclasses no assembly)
* 6 - private (própria classe)

# ✔️ Classes e Métodos selead

* Classe - Impede que a Classe possa ser Herdada
sealed class Product {...}
* Método - Impede o método de ser sobreposto novamente.
public sealed override void WithDraw (double amount) {...}

# ✔️ Classes Tratamento de Exceções

* Tratar erros de forma consistente e flexível. Principais são Exception (SystemException / ApplicationException)
* 1 - try (Código que é executado e pode ocorrer um erro)
* 2 - catch (Código que irá capturar e mostrar as mensagens de erro)
* 3 - finally (Código que é executado independente se houver ou não, um erro)
* Classe SystemException (IndexOutofRangeException, NullReferenceException, InvalidCastException, OutOfmemoryException, ArgumentException(ArgumentNullException, ArgumentOutOfRangeException) , ExternalExcption(ComException, SEHException), ArithmeticException(DivideByZeroException, OverflowException) ))

# ✔️ Classes Tratam Arquivos

* File, FileInfo, FileStream, StreamReader, StreamWriter - Pertencem ao NameSpace System.IO
* IOException (DirectoryNotFoundException, DriveNotFoundException, EndOfStreamException, FileLoadException, FileNotFoundException, PathTooLongException, PipeException)
NameSpace System.IO
* Objetos IDisposable não são gerenciados pelo CLR e precisam ser fechados manualmente: Font, FileStream, StreamReader, StreamWriter.
* E como alternativa, o C# possui o bloco using(){}, os objetos instânciados dentro dele é finalizado ao encerrado a execução do bloco. Ele permite ser cascateado também, using () { using () { } }
* Path - nameSpace System.IO, realiza operações com strings que contém informações de arquivos de pastas
* Trabalha com Diretórios : Directory - operações static, não precisa instânciar. DirectoryInfo - operações instância.

# ✔️ Interfaces

* Interface é um tipo que define um conjunto de operações que uma classe ou struct deve implemtar ao receber a determinada interface. Permite Baixo Acoplamento e flexíveis.
* Injeção de dependência, informar o objeto por meio do construtor, para qual ele implementa a determinada interface
* Inversão de Controle : Padrão de desenvolvimento que consiste em retirar da classe a responsabilidade de instânciar suas dependências.
* Injeção de dependência : É uma forma de realizar a inversão de controle: um componente externo instãncia a dependência, que é então injetada no objeto "pai".
* Pode ser implementada pelo Construtor, Objetos de Instãnciação (Builder / Factory), Container / Framework
* Herança (Herda as caracteristicas - Reuso) X Interfaces (Deve cumprir Implementação do contrato). Relação é-um, Generalização / Especialização, Polimorfismo
* O problema de Herança Multipla ou Diamante, que o CLR não permite, pode ser implementada de outra forma usando Interfaces.
* Interface IComparable - Interface para comparar um objeto com outro, menor, maior ou igual - Compara dois objetos retornando um número inteiro

# ✔️ Generics

* Generics, permitem que classes, interfaces e métodos possam ser parametrizados por seu tipo. Oferecem Reuso, Type Safety, Performance, uso comum - Coleções.
* GetHashCode e Equals - Classe Object, usada para comparar Objetos.
* NameSpace - using System.Collections.Generic : HashSet<T> e SortedSet<T>, representa conjunto de elementos, possui interseção, união, diferença e não permite repetições, não posuem posição.
* HashSet - Armazena em Tabela hash, Extremamente rápido, inserção, remoção e busca O(1). Ordem elementos não garantida.
* SortedSet - Armazena em árvore, rápido, inserção, remoção e busca O(Log(n)). Armazenados ordenadamente conforme implementação
IComparer<T>.
* Alguns operações de métodos : add, clear, contais, unionwith, intersectwith, exceptwith, remove(T), removewhere(predicate).
* Se GetHashCode e Equals NÃO estiverem implementados, Tipos referência: compara as referências dos objetos.
* Tipos valor: comparar os valores dos atributos.
* Dictionary<TKay, TValue> : Coleção de pares (chave e valor), não permite repetição objeto chave. Elementos indexados pela chave - não possui posição, permite inserção e remoção.
* Dictionary : Armazena em tabela hash, extremamente rápido, possui inserção, remoção e busca O(1), ordem elementos não garantida.
* SortedDictionary : Armazena em árvore, rápida inserção, remoção e busca O(log(n) ). Elementos são armazenados ordenadamente conforme implantação, usa IComparer<T>.
* Métodos (dictionary[key], add(key, value), clear(), count, containskey(key), containsValue(value), remove(key) ).

# ✔️ Métodos de Extensão

* Métodos de Extensão estendem a funcinalidade de um tipo classe ou struct, sem precisar alterar o código ou herdar esse tipo.
* Passos para criar um método de extensão: 1 - Criar uma classe estática, 2 - Na classe, criar um método estático, 3 - O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um parâmetro do tipo que deseja estender. Esta será uma referência para o próprio objeto.

# ✔️ Expressões Lambda, Delegates e LINQ

* Delegates - Referência (com type-safe) para um ou mais métodos, tipo referência : Action, Func, Predicate.
* Multicast Delegates - Guardam referência para mais de um método.
* Delegate Predicate, recebe um objeto do tipo T e retorna booleano.
* Delegate Action - Método que recebe zero ou mais argumentos, possui 16 Sobrecargas.
* Delegate Func - Função de LINQ : Método que recebe zero ou mais argumentos e retorna valor, possui 16 sobrecargas.

## 🎯 Algumas Operações LINQ :
## LINQ - Language Integrated Query - Namespace : System.Linq
## Operações chamadas diretamente a partir das coleções. Possui diversas operações de consulta, como expressões Lambda e expressões de sintaxe SQL.

- Filtering - Where, OfType
- Sorting - OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
- Set - Distinct, Except, Intersect, Union
- Quantification - All, Any, Contains
- Projection - Select, SelectMany
- Partition - Skyp, Take
- Join - Join, GroupJoin
- Grouping - GroupBy
- Generational - Empty
- Equality - SequenceEquals
- Element - ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
- Conversions - AsEnumerable, AsQueryable
- Concatenation - Concat
- Aggregation - Aggregate, Average, Count, LongCount, Max, Min, Sum 
