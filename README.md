<p align="center">
     <img src="/imagens/csharp_logo.png" alt="C#" width="250px" />
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

### C# é Versátil

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
	
### Mercado

C# é uma das linguagens **mais utilizadas no mundo**, com uma breve busca no LinkedIn você encontra diversos empregos para quem trabalha com ela.
Cada região tem um salário, mas profissionais experientes são **muito bem remunerados**.

### .NET Core

O framework **.NET Core** da Microsoft permite desenvolvimento multiplataforma e é extremamente performático e modular

### Comunidade Gigantesca

Você pode aprender C# em diversos lugares diferentes e de graça. Além desse tutorial, vou deixar mais alguns links para ajudar no seu estudo:
* http://www.macoratti.net/08/08/c_bas1.htm
* https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/
* https://www.udemy.com/pt/topic/c-sharp/free/

## Mão na Massa - Problema

Então pessoal, neste tutorial, faremos uma aplicação que armazena números em uma **pilha**. 

Uma pilha é uma estrutura de dados do tipo **Último a entrar, Primeiro a sair** (LIFO, First In First Out em inglês). 

<p align="center">
	<img src="/imagens/pilha.png" alt="pilha" width="450px" />
</p>

Por padrão, já temos um objeto no C# que simula esse comportamento, a **Stack**.
Este tem os seguintes comandos:
* **Push** insere um elemento no topo da Pilha
* **Pop** remove o elemento no topo da Pilha
* **Peek** retorna o elemento no topo da Pilha
* **Count** retorna o tamanho da Pilha

Nossa aplicação será feita em **CLI** (Interface de Linha de Comando), mais conhecido como console. Poderemos entrar com 
diversos comandos e para cada comando irá ser realizada uma ação.

### Comandos da aplicação

* `N` - Adiciona um número de valor **N** a pilha.
* `DUP` - **Duplica** o último item da pilha
* `POP` - **Remove** o último item da pilha
* `INV` - **Inverte** a pilha
* `+` - **Soma os dois últimos** itens da pilha, removendo o último
* `-` - **Subtrai os dois últimos** itens da pilha, removendo o último

### Regras

* O tamanho máximo da pilha é de 10 números
* O número a ser adicionado na pilha não pode ser negativo
* O número a ser adicionado na pilha não pode ser maior que 999
* Comando `DUP` deve retornar um erro caso a pilha esteja vazia
* Comando `DUP` deve retornar um erro caso a duplicação supere o tamanho máximo da pilha
* Comando `POP` deve retornar um erro caso a pilha esteja vazia
* Comando `INV` deve retornar um erro caso a pilha esteja vazia
* Comandos `+` e `-` devem retornar um erro caso o tamanho da pilha seja 1

### Casos de Erro

Qualquer situação inesperada deve exibir uma mensagem de erro na tela informando o que aconteceu, por exemplo:
<img src="/imagens/erro.png" alt="erro" width="450px" />

### Exemplo da aplicação funcionando:

<img src="/imagens/app.png" alt="app" width="250px" />

## Mão na Massa - Tutorial

### Configuração de Ambiente

01. [Instalando e configurando o **Visual Studio**](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/ambiente/1.instalando_visual_studio.md)

### Desenvolvimento

02. [Criando o Projeto](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/2.criar-projeto.md)
03. [Desenvolvimento Dirigido a Testes](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/3.desenvolvimento-dirigido-a-testes.md)
04. [Implementação](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/4.implementacao.md)
05. [Adicionando números a pilha](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/5.adicionando-numeros-na-pilha.md)
06. [Comandos](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/6.comandos.md)
07. [Implementação comando `DUP`](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/7.comando-dup.md)
08. [Implementação comando `POP`](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/8.comando-pop.md)
09. [Implementação comando `INV`](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/9.comando-inv.md)
10. [Implementação comando `+` e `-`](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/10.comando-mais-menos.md)
11. [Executando a aplicação](https://github.com/Go-Horse-Coding/csharp-tutorial/blob/master/modulos/tutorial/11.executar-aplicacao.md)

# Autores
* [Felipe Almeida](https://github.com/felipe-allmeida) - Fundador do GoHorse Coding e Engenheiro de Software

# Referências

* https://docs.microsoft.com/pt-br/dotnet/csharp/
* http://www.macoratti.net/08/08/c_bas1.htm
* https://www.c-sharpcorner.com/UploadFile/mahesh/what-can-C-Sharp-do-for-you/
* http://gabsferreira.com/razoes-pra-c-ser-sua-primeira-linguagem-de-programacao/
* https://gameprogrammingpatterns.com/
* https://docs.microsoft.com/pt-br/visualstudio/test/unit-test-basics?view=vs-2019

