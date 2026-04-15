
int opcao;
double valor;
double valorfinal;

Console.WriteLine("Digite o valor total da compra: R$ ");
valor = double.Parse(Console.ReadLine());

   Console.WriteLine("Escolha a forma de pagamento:");
    Console.WriteLine("1 - À vista");
   Console.WriteLine("2 - cartao");
   Console.WriteLine("3 - parcelado");

    opcao = int.Parse(Console.ReadLine());
    valorfinal = valor;

switch (opcao)
{
    case 1:
    valorfinal = valor * 0.90; 
    Console.WriteLine("Pagamento a vista(10% de desconto).");
    break;

    case 2:
    Console.WriteLine("Pagamento de cartâo(sem alteraçâo).");
    break;

    case 3:
    Console.WriteLine("Pagamento parcelado(5% de juros).");
    break;

    default:
     Console.WriteLine("opçao invalida. ");
     return;
}
Console.WriteLine($"valor final: R$ {valorfinal}");

    

    