# Desafio Itaú

## Introdução

Este é um Projeto de Desafio do Itaú que consiste em criar uma API que irá expor um endpoint para verificar se uma determinada senha é válida, seguindo os critérios abaixo:

- Possuir nove ou mais caracteres
- Possuir ao menos 1 dígito
- Possuir ao menos 1 letra minúscula
- Possuir ao menos 1 letra maiúscula
- Possuir ao menos 1 dos caracteres especiais a seguir: !@#$%^&*()-+
- Não possuir caracteres repetidos dentro do conjunto
- Não possuir espaços em branco

Exemplo: 
```c#
IsValid("") // false
IsValid("aa") // false
IsValid("ab") // false
IsValid("AAAbbbCc") // false
IsValid("AbTp9!foo") // false 
IsValid("AbTp9!foA") // false
IsValid("AbTp9 fok") // false
IsValid("AbTp9!fok") // true
```
## Descrição do Projeto

Para a execução deste Desafio, foi criado um Projeto Web API no Visual Studio 2017 utilizando a linguagem C#. Apesar da API expor apenas um endpoint, a aplicação foi construída utilizando algumas das melhores práticas da modelagem DDD.

## Executando a Aplicação

**1.** Após clonar o Projeto do Git em seu Ambiente de Desenvolvimento, abra a **Solution** no Visual Studio 2017 ou superior.

**2.** Com o botão direito na **Solution** execute a opção **"Restore NuGet Packages"** para baixar os pacotes externos que foram utilizados no desenvolvimento da Aplicação.

![]((images/readme01.png)
