# CSharp Notebook

### Objetivos
Acredito que aprendo melhor quando faço anotações. Portanto, com o objetivo de acompanhar meu progresso e registrar meus estudos e projetos em C#, criei este repositório. Farei uma introdução, uma breve recapitulação de Lógica de Programação e seguiremos com conceitos de Programação Orientada a Objetos. Paralelamente, desenvolveremos alguns projetos. Todos os estudos serão organizados em pastas.

Abaixo vocês terão acesso aos projetos realizados até aqui.

<details>
  <summary>:heavy_check_mark: Projetos Realizados</summary>
</details>

## Introdução

### O que é uma linguagem de programação?
É um sistema de comunicação estruturado, composto por um conjunto de símbolos, palavras-chave, regras semânticas e sintáticas que permitem que um programador se comunique com a máquina.

Computadores utilizam apenas linguagem binária. Dessa forma, o código é traduzido para a linguagem do computador. Chamamos esse processo de tradução de compilação e cada linguagem tem seu compilador.

### Classificações

Existem dois tipos de linguagens, os quais chamamos de linguagem de alto nível e linguagem de baixo nível.

Chamamos de linguagem de alto nível aquela cuja sintaxe é voltada para o entendimento humano. Isso significa que esse tipo de linguagem é muito mais intuitivo, amigável e mais fácil de aprender. Já as linguagemns de baixo nível são voltadas para o entendimento da máquina, isto é, elas têm uma sintaxe mais complexa e não contam com comandos tão intuitivos.

|                    Linguagens Compiladas                     |                   Linguagens Interpretadas                   |
| :----------------------------------------------------------: | :----------------------------------------------------------: |
| As linguagens compiladas são convertidas diretamente na máquina em um código de máquina que o processador pode executar. | Os interpretadores passam pelo programa linha por linha e executam cada comando. |

A maioria das linguagens de programação pode ter implementações compiladas e interpretadas – a linguagem em si não é necessariamente compilada ou interpretada. Porém, para fins de simplicidade, elas são normalmente referidas deste modo.

Também é possível caracterizar uma linguagem quanto à sua tipagem. C# é uma linguagem fortemente tipada, pois obriga o programador a especificar o tipo de dado a ser tratado, o que ajuda a evitar erros por manipulação imprópria de tipos e atribuições incorretas.

Dessa forma, podemos dizer que C# é uma linguagem de alto nível, compilada e fortemente tipada.

### C# e .NET
É importante começar definindo o que é C# e o que é .NET para que ambos não sejam confundidos.

C# é uma linguagem de programação desenvolvida pela Microsoft em 2000.

.NET é um framework, isto é, um conjunto de bibliotecas desenvolvidas pela Microsoft para o desenvolvimento de aplicações. Dessa forma, .NET é o ambiente de execução que executa os códigos escritos nas linguagens que compõem o ambiente, sendo C# uma destas linguagens.

#### Mais sobre o .NET
O .NET possui dois componentes, sendo eles:

**Framework Class Library (FCL):** é uma biblioteca que contém várias classes, tipos de dados, interfaces, etc, de forma a executar várias funções e construir diferentes tipos de aplicativos, como aplicativos de desktop, aplicativos da web, aplicativos móveis, etc.

**Common Language Runtime (CLR):** é uma máquina virtual que executa os programas feitos no .NET. É aqui que o código é convertido em linguagem de máquina de forma que o processador possa executar o programa.

## Comandos iniciais .NET

- Para criar um novo projeto:

```powershell
dotnet new console -o MeuApp
```

- Comando que busca todos os pacotes que a aplicação precisa para ser executada:

```powershell
dotnet restore
```

- Comando que compila:

```powershell
dotnet build
```

- Comando que limpa o cache:

```powershell
dotnet clean
```

- Comando que roda a aplicação:

```powershell
dotnet run
```

## Referências

[What is .NET?](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)

[Common Language Runtime](https://en.wikipedia.org/wiki/Common_Language_Runtime)

[C# COMPLETO Programação Orientada a Objetos + Projetos](https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/)

[Linguagem de alto nível vs linguagem de baixo nível: definições e diferenças!](https://blog.betrybe.com/linguagem-de-programacao/linguagem-alto-e-baixo-nivel/)
