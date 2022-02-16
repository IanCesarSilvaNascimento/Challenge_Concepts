# Desafio_Capgemini

## Questao1
Escreva um algoritmo que mostre na tela uma escada de tamanho n utilizando o caractere * e espaços. A base e altura da escada devem ser iguais ao valor de n. A última linha não deve conter nenhum espaço.

## Resolução
Utilizei método padrão de leitura e escrita no console - disponível na lib System. 

Utilizei o método para instanciar uma lista - disponível na lib system.collections.generic.

Utilizei o método Stairs para receber o parâmetro do console e determinar o final da contagem de um loop.

Adicionei os itens concatenados na lista repetindo o espaço de acordo com a contagem de espaço(gap) e o caracter(*) de acordo com a contagem do loop.

## Como utilizar
Clone o repositorio e digite na CLI.
```Code
dotnet run 
```
## Questao2
Débora se inscreveu em uma rede social para se manter em contato com seus amigos. A página de cadastro exigia o preenchimento dos campos de nome e senha, porém a senha precisa ser forte. O site considera uma senha forte quando ela satisfaz os seguintes critérios:

Possui no mínimo 6 caracteres.

Contém no mínimo 1 digito.

Contém no mínimo 1 letra em minúsculo.

Contém no mínimo 1 letra em maiúsculo.

Contém no mínimo 1 caractere especial. Os caracteres especiais são: !@#$%^&*()-+

Débora digitou uma string aleatória no campo de senha, porém ela não tem certeza se é uma senha forte. Para ajudar Débora, construa um algoritmo que informe qual é o número mínimo de caracteres que devem ser adicionados para uma string qualquer ser considerada segura.


## Resolução
Utilizei método padrão de leitura e escrita no console - disponível na lib System. 

Utilizei uma classe Password.cs para receber os parâmetros do console, instanciando a classe e passando o parâmetro. Também utilizei um conceito de injeção de dependência para privar a atribuição da propriedade Passwords dentro desta classe citada.

Utilizei o método ValidateNumberOfCharacters() para fazer as validações necessárias e retornar verdadeiro se todos os requisitos fossem atendidos, caso contrário envia uma mensagem sobre o requisito que falta e depois uma mensagem de falha.


## Como utilizar
Clone o repositorio e digite na CLI.
```Code
dotnet run 
```
## Questao3
Duas palavras podem ser consideradas anagramas de si mesmas se as letras de uma palavra podem ser realocadas para formar a outra palavra. Dada uma string qualquer, desenvolva um algoritmo que encontre o número de pares de substrings que são anagramas.


## Resolução
Utilizei método padrão de leitura e escrita no console - disponível na lib System. 

Utilizei uma classe Anagram.cs para receber os parâmetros do console, instanciando a classe e passando o parâmetro. Também utilizei um conceito de injeção de dependência para privar a atribuição da propriedade Passwords dentro desta classe citada.

Utilizei um método para converter a string do console em array.

Utilizei um método para converter a string do console em array invertida.

Utilizei o método Validate() para fazer as validações necessárias e retornar verdadeiro se todos os requisitos fossem atendidos.


## Como utilizar
Clone o repositorio e digite na CLI.
```Code
dotnet run 
```

