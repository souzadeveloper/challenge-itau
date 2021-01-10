# Desafio Itaú

## Introdução

Este é um Projeto de Desafio do Itaú que consiste em criar uma API que irá expor um endpoint para verificar se uma determinada senha é válida, seguindo os critérios abaixo:

- Possuir nove ou mais caracteres
- Possuir ao menos 1 dígito numérico
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

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme01.png">

**3.** Novamente com o botão direito na **Solution**, execute a agora a opção **"Build Solution"** para compilar todos os Projetos da aplicação. Se tudo correu bem você terá uma tela igual a imagem abaixo:

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme02.png">

**4.** Agora você já está apto para executar a API clicando no botão da imagem abaixo:

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme03.png">

## Consumindo a API

Ao executar a API pelo Visual Studio, a aplicação irá disponibilizar o endpoint abaixo:

```c#
POST /api/auth/checkPassword HTTP/1.1
Host: http://localhost:57524
Content-Type: application/json
```

Este endpoint espera receber a Senha que será validada. Para informar a senha, deverá ser enviado no **body** da mensagem um conteúdo do Tipo Json no formato abaixo:
```c#
{
	"password": "AbTp9!fok"
}
```
O endpoint **checkPassword** devolve um valor booleano igual a **true** caso a senha seja válida ou igual a **false** caso a senha seja inválida, de acordo com os critérios definidos no início desta documentação.

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme04.png">

## Entendendo a Validação da Senha

Para validar a senha foram implementados alguns métodos genéricos na nossa camada **Framework** para validar as situações abaixo:

- Método para verificar se uma string contém algum dígito numérico
- Método para verificar se uma string contém algum caractere com UpperCase
- Método para verificar se uma string contém algum caractere com LowerCase

Esses métodos por serem genéricos podem ser utilizados em outras situações que a nossa aplicação possa precisar.

Além desses métodos, foram criados mais alguns métodos na Classe **PasswordHelper** por se tratar de regras específicas para a validação de senha. Nesta classe temos:

- Método para validar se a senha tem os caracteres especiais válidos
- Método para validar se a senha tem algum caractere duplicado.  

Com esses 5 métodos conseguimos criar facilmente em nosso Helper o método **IsValid** que realizará a  validação de senha:

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme04.png">

## Testes Unitários

Para testar o código da nossa API, junto com a aplicação temos o nosso projeto de Testes Unitários onde estamos testando nossa rotina de Validação de Senha:

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme05.png">

A nossa classe de Testes testa algumas situação onde a nossa rotina deverá retornar **true** e algumas onde deverá retornar **false**:

<img src="https://github.com/souzadeveloper/challenge-itau/blob/master/images/readme06.png">
