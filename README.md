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

Então pessoal, neste tutorial, faremos uma aplicação que armazena números em uma **pilha**. 
Nossa aplicação será feita em **CLI** (Command Line Interface), mais conhecido como console. Poderemos entrar com 
diversos comandos e para cada comando irá ser realizada uma ação.

### Comandos da aplicação

* `N` - Adiciona um número de valor **N** a pilha.
* `DUP` - **Duplica** o último item da pilha
* `POP` - **Remove** o último item da pilha
* `INV` - **Inverte** a pilha
* `+` - **Soma os dois últimos** itens da pilha, removendo o último
* `-` - **Subtrai os dois últimos** itens da pilha, removendo o último
* `PTR` - **Exibe** na tela todos os números armazenados na pilha
* `CLS` - **Limpa** a tela do console

### Regras

* O tamanho máximo da pilha é de 10 números
* O número a ser adicionado na pilha não pode ser negativo
* O número a ser adicionado na pilha não pode ser maior que 999
* Comando `DUP` deve retornar um erro caso a duplicação supere o tamanho máximo da pilha
* Comando `POP` deve retornar um erro caso não tenha números para remover
* Comando `INV` deve retornar um erro caso a pilha não tenha números
* Comandos `+` e `-` devem retornar um erro caso o tamanho da pilha seja 1

### Casos de Erro

Qualquer situação inesperada deve exibir uma mensagem de erro na tela informando:

* Os números na pilha
* Comando que falhou
* Data e hora da falha
```C#
============ ERROR START
1 5 15 17 - POP | 04/28/2020 07:04:52
============= ERROR END
```

### Exemplo da aplicação funcionando:

1. Comando digitado: `13` 	-> **Pilha:** [13]
2. Comando digitado: `DUP` 	-> **Pilha:** [13, 13]
3. Comando digitado: `4` 	-> **Pilha:** [13, 13, 4]
4. Comando digitado: `POP` 	-> **Pilha:** [13, 13]
5. Comando digitado: `5` 	-> **Pilha:** [13, 13, 5]
6. Comando digitado: `DUP` 	-> **Pilha:** [13, 13, 5, 5]
7. Comando digitado: `+` 	-> **Pilha:** [13, 13, 10]
8. Comando digitado: `DUP` 	-> **Pilha:** [13, 13, 10, 10]
9. Comando digitado: `+` 	-> **Pilha:** [13, 13, 20]
10. Comando digitado: `-` 	-> **Pilha:** [13, 7]

## Mão na Massa - Tutorial

### Configuração de Ambiente

01. [Instalando e configurando o **Visual Studio**](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/ambient/1.installing_vs.md)

### Desenvolvimento

02. [Criando o Projeto](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/2.create-project.md)
03. [Desenvolvimento Dirigido a Testes](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/3.test-driven-development.md)
04. [Implementação](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/4.implementation.md)
05. [Adicionando números a pilha](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/5.add-number-to-stack.md)
06. [Comandos](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/6.commands.md)
07. [Implementação comando `DUP`](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modules/tutorial/7.dup-command.md)
08. [Implementação comando `POP`]()
09. [Implementação comando `INV`]()
12. [Implementação comando `PTR`]()
13. [Implementação comando `CLS`]()
10. [Implementação comando `+`]()
11. [Implementação comando `-`]()



## Referências

* https://docs.microsoft.com/pt-br/dotnet/csharp/
* http://www.macoratti.net/08/08/c_bas1.htm
* https://www.c-sharpcorner.com/UploadFile/mahesh/what-can-C-Sharp-do-for-you/
* http://gabsferreira.com/razoes-pra-c-ser-sua-primeira-linguagem-de-programacao/
* https://gameprogrammingpatterns.com/

