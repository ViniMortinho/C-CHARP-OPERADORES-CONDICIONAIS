# Operadores Condicionais

Os operadores condicionais são uma ferramenta essencial para a programação, pois permitem controlar o fluxo do código com base em certas condições. Eles avaliam uma expressão booleana e executam diferentes blocos de código dependendo do resultado.

## Instruções Condicionais

A linguagem C# fornece três instruções condicionais:

- `if`: A instrução `if` executará uma instrução somente se uma expressão booleana fornecida for avaliada como verdadeira.
- `if-else`: A instrução `if-else` permite que você escolha qual dos dois caminhos de código seguir com base em uma expressão booleana.
- `switch`: A instrução `switch` seleciona uma lista de instruções a ser executada com base em uma correspondência de padrão com uma expressão.

## Operador Condicional

O operador condicional `?:` é uma forma concisa de escrever uma instrução if-else em um contexto de expressão. Ele avalia uma expressão booleana e retorna um valor dependendo do resultado.

```csharp
int idade = 18;

string mensagem = idade >= 18 ? "Você é maior de idade." : "Você é menor de idade.";

Console.WriteLine(mensagem); // "Você é maior de idade."

##Instruções Aninhadas
 - Você também pode aninhar instruções if para verificar várias condições. Por exemplo, você pode usar um if para executar um bloco de código se a condição for verdadeira, ou usar um else para executar um bloco de código alternativo se a condição for falsa. Isso permite tomar decisões no seu código com base em certas condições.
 int idade = 17;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    if (idade >= 16)
    {
        Console.WriteLine("Você é menor de idade, mas está perto de ser maior de idade.");
    }
    else
    {
        Console.WriteLine("Você é menor de idade e ainda não pode votar.");
    }
}

##Classe Pessoa
A classe Pessoa abaixo serviu de base para a elaboração deste estudo:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.models
{
    public class Pessoa
    {
        public string Nome  { get; set; }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
