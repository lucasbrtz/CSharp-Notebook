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

### C# e .NET
É importante começar definindo o que é C# e o que é .NET para que ambos não sejam confundidos.

C# é uma linguagem de programação desenvolvida pela Microsoft em 2000.

.NET é um framework, isto é, um conjunto de bibliotecas desenvolvidas pela Microsoft para o desenvolvimento de aplicações. Dessa forma, .NET é o ambiente de execução que executa os códigos escritos nas linguagens que compõem o ambiente, sendo C# uma destas linguagens.

#### Mais sobre o .NET
O .NET possui dois componentes, sendo eles:

**Framework Class Library (FCL):** é uma biblioteca que contém várias classes, tipos de dados, interfaces, etc, de forma a executar várias funções e construir diferentes tipos de aplicativos, como aplicativos de desktop, aplicativos da web, aplicativos móveis, etc.

**Common Language Runtime (CLR):** é uma máquina virtual que executa os programas feitos no .NET. É aqui que o código é convertido em linguagem de máquina de forma que o processador possa executar o programa.

## Comandos iniciais .NET

- Para criar um novo projeto console:

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
