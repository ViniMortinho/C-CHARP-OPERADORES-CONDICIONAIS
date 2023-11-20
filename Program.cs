using ExemplosFundamentos.models;
Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
    Console.WriteLine("Você digitou uma vogal!");
    break;
    default:
    Console.WriteLine("Você não digitou uma vogal!");
    break;
}


//SEGUNDO EXEPLO
/* if (letra =="a" || 
    letra =="e" || 
    letra =="i" || 
    letra =="o" || 
    letra =="u")
 {Console.WriteLine("Vogal");}

 else
 {
    Console.WriteLine("Não é uma vogal");
 }
     */











//PRIMEIRO EXEMPLO 

/* string letra = Console.ReadLine();
//readLine vai permitir que o terminal espere por algum comando a ser digitada

if (letra == "a"){
    Console.WriteLine("Vogal");
}
 else if (letra == "e" ){
    Console.WriteLine("Vogal");
 }

else if (letra == "i" ){
    Console.WriteLine("Vogal");
 }
 else if (letra == "o" ){
    Console.WriteLine("Vogal");
 }
 else if (letra == "u" ){
    Console.WriteLine("Vogal");
 }
 else {
    Console.WriteLine("Não é uma vogal");
    }
    
 
 */





















/* using ExemplosFundamentos.models;

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




 */