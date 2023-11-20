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




