# Repositório em construção!

<p align="center">
     <img src="/images/csharp_logo.png" alt="C#" width="250px" />
</p>

# .NET - Introdução ao C# 
*Este artigo foi escrito em abril de 2020*

## O que é C#?

C# é uma linguagem de programação, multiparadigma, de [tipagem forte](https://github.com/Go-Horse-Coding/programming-concepts-tutorial/blob/master/Concepts/typing.md)
desenvolvida pela **Microsoft** como parte da **plataforma .NET**. A sua sintaxe orientada a objetos foi baseada no C++ mas inclui muitas influências de outras linguagens
de programação, como Object Pascal e, principalmente, Java.

<br>

## Por que C# como primeira linguagem?

Não existe resposta certa para essa pergunta e cada pessoa provavelmente vai te dar uma resposta diferente se baseando em seu gosto e experiência. 
Então pretendo te apresentar algumas coisas legais que o C# oferece que me fazem acreditar que ele é uma ótima linguagem para se iniciar.

### -> C# é Versátil

Com ele você pode desenvolver:
* Aplicações para Windows
* Aplicações WEB
* Serviços WEB e WEB API
* Apps nativos iOS e android
* Inteligência Artificial e Machine Learning
* Aplicações e Serviços com a Azure Cloud
* Aparelhos com Internet das Coisas (IoT) 
* Video Games
* E muito mais
	
### -> Mercado

C# é uma das linguagens **mais utilizadas no mundo**, com uma breve busca no LinkedIn você encontra diversos empregos para quem trabalha com ela.
Cada região tem um salário, mas profissionais experientes são **muito bem remunerados**.

### -> .NET Core

O framework **.NET Core** da Microsoft permite desenvolvimento multiplataforma e é extremamente performático e modular

### -> Comunidade Gigantesca

Você pode aprender C# em diversos lugares diferentes e de graça. Além desse tutorial, vou deixar mais alguns links para ajudar no seu estudo:
* http://www.macoratti.net/08/08/c_bas1.htm
* https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/
* https://www.udemy.com/pt/topic/c-sharp/free/

## Mão na Massa - Problema

Então pessoal, neste tutorial, faremos uma aplicação que armazena operações em uma **pilha** do início ao fim. Poderemos entrar com diversos comandos e para cada um irá ser realizada uma ação
em particular.


### Comandos

* `[Number]` - Um número que varia de 0 a 2147483647, o mesmo não pode ser negativo.
* `DUP` - **Duplica** o último item da pilha
* `POP` - **Remove** o último item da pilha
* `INV` - **Inverte** a pilha
* `+` - Soma os dois últimos itens da pilha, removendo o último
* `-` - Subtrai os dois últimos itens da pilha, removendo o último
* `PTR` - **Exibe** na tela todos as operações armazenados na stack
* `CLS` - **Limpa** a tela

### Casos de Erro

Qualquer situação inesperada deve exibir uma mensagem de erro na tela informando:

* Os números na pilha
* Comando que falhou
* Hora da falha
```C#
============ ERROR START
1 5 15 17 - POP | 04/28/2020
============= ERROR END
```


### Exemplos de entradas e saídas

**Entrada:** `3 DUP 5 - -` <br/>
**Resultado:** -1

<br/>

**Entrada:** `13 DUP 4 POP 5 DUP + DUP + -` <br/>
**Resultado:** 7

<br/>

**Entrada:** `5 6 + -` <br/>
**Resultado:** -1

## Mão na Massa - Tutorial

### Configuração de Ambiente

01. [Instalando e configurando o **Visual Studio**](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/ambient/1.installing_vs.md)

### Desenvolvimento

02. [Criando o Projeto](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/2.create-project.md)
03. [Desenvolvimento Dirigido a Testes]()
04. [Máquina de Operações]()
05. [Pilha de Operações]()
06. [Comando `PUSH`]()
07. [Comando `POP`]()
08. [Comando `INV`]()
09. [Comando `+`]()
10. [Comando `-`]()
11. [Comando `PTR`]()
12. [Comando `CLS`]()


## Referências

* https://docs.microsoft.com/pt-br/dotnet/csharp/
* http://www.macoratti.net/08/08/c_bas1.htm
* https://www.c-sharpcorner.com/UploadFile/mahesh/what-can-C-Sharp-do-for-you/
* http://gabsferreira.com/razoes-pra-c-ser-sua-primeira-linguagem-de-programacao/
* 

