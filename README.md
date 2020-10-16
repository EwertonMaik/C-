# Linguagem de Programação C#
Usando Visual Studio 2019 / .NET Framework e .NET CORE

Debugging com Visual Studio

F9 - Marcar / Desmarcar BreakPoint

F5 - Iniciar / Continuar o Debug

F10 - Executar um passo (pula função)

F11 - Executar um passo (entra na função)

SHIFT + F11 - Sair método em execução

SHIFT + F5  - Parar Debug

Este repositório contêm alguns exemplos práticos e projetos em desenvolvimentos da Linguagem C# usando;
Classes, Atributos, Encapsulamento, Construtores, Estruturas IF ElSE - Simples, Composta, Encadeada e Ternário. Estrutura For, Foreach,
Estrutura While, Métodos, Sobrecarga, Métodos, Construtores, Herança, Polimorfismo entre outros recursos.
Uso de this para diferênciar atributos de variáveis locais. Nullable, Vetores, Matrizes, Listas, Modificador Params, Ref e Out.
Enum, Boxing e Unboxing, composição, Upcasting, Downcasting.

# Tipo de Dados Referência e Tipo Valor/Struct.
Classe - Vantagem: usa todos recursos OO), Variáveis são ponteiros, precisa ser instânciada new, aceita valor null, suporta herança, y = x (y recebe o ponteiro de x), objetos instânciados do heap, objetos não utilizados são desalocados em um momento próximo pelo Garbage Collector.

Struct - Struct (É mais simples e performático, variáveis são caixa, não é preciso instânciar, mais é possível, não aceita null, não tem suporte a herança, aceita interfaces, y = x (recebe uma cópia de x), objetos instanciados no stack, objetos são desalocados imediatamente quando seu escopo de execução é finalizado ).

# Memória - Stack e Heap
Garbage Collector - Processo que gerencia memória de um programa. Monitora objetos dinamicamente no heap, desalocando os que não estão sendo mais usados.

Desalocação por Escopo - O que é alocado dentro de um método é desalocado assim que a execução sair do escopo.
Variáveis locais são desalocadas imediatamente assim que seu escopo local sai de execução.

# Valores Padrão tipo de dados Classe, Struct, Arrays
Números = 0;
bool = false;
char = caractere código 0;
objeto = null;

# Ordem de Construção de uma Classe
Atributos privados

Propriedades autoimplementadas

Construtores

Propriedades Customizadas

Outros Métodos da classe

# Modificadores de Acesso para Membro de uma Classe

1 - public (própria classe / subclasses no assembly / classes do assembly / subclasses fora do assembly / classes fora do assembly)

2 - protected internal (própria classe / subclasses no assembly / classes do assembly / subclasses fora do assembly)

3 - internal (própria classe / subclasses no assembly / classes do assembly)

4 - protected (própria classe / subclasses no assembly / subclasses fora do assembly)

5 - private protected (própria classe / subclasses no assembly)

6 - private (própria classe)
