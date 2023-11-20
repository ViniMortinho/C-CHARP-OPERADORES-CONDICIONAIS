# Documentação de Operadores Condicionais em C#

Os operadores condicionais em C# são usados para tomar decisões com base em condições. Os operadores condicionais mais comuns em C# são:

## Operador If

O operador `if` é usado para executar um bloco de código se uma condição especificada for verdadeira.

```csharp
using ExemplosFundamentos.models;

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"quantidade em estoque:{quantidadeEmEstoque}");
Console.WriteLine($"quantidadeCompra:{quantidadeCompra}");
Console.WriteLine($"É possivél realizar a venda?{possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda Invalida!");
}
```

## Operador Else

O operador `else` é usado para executar um bloco de código se a condição do `if` for falsa.

```csharp
using ExemplosFundamentos.models;

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"quantidade em estoque:{quantidadeEmEstoque}");
Console.WriteLine($"quantidadeCompra:{quantidadeCompra}");
Console.WriteLine($"É possivél realizar a venda?{possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda Invalida!");
}
else {
    Console.WriteLine("A venda é valida!");
}
```

## Operador Else If

O operador `else if` é usado para especificar uma nova condição se a primeira condição for falsa.

```csharp
using ExemplosFundamentos.models;

int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"quantidade em estoque:{quantidadeEmEstoque}");
Console.WriteLine($"quantidadeCompra:{quantidadeCompra}");
Console.WriteLine($"É possivél realizar a venda?{possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda Invalida!");
}
else if (possivelVenda) {
    Console.WriteLine("A venda é valida!");
}
else {
    Console.WriteLine("Não há produtos suficientes no estoque para essa compra.");
}
```

Para mais informações sobre operadores condicionais em C#, você pode consultar a [documentação oficial da Microsoft](https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/conditional-operator).

Agradeço ao professor Leonardo Buta por sua contribuição para este curso.
Você pode encontrar mais sobre ele em seu perfil no GitHub 
[Link](https://github.com/leonardo-buta)
 