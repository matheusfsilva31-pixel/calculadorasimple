int categoria;
double valor, valorfinal;

Console.WriteLine("informe o valor do produto: R$ ");
valor = double.Parse(Console.ReadLine());

Console.WriteLine("\nMENU DE CATEGORIA:");
Console.WriteLine("1 - Alimento");
Console.WriteLine("2 - limpeza");
Console.WriteLine("3 - eletronico");
Console.WriteLine("Escolha a categoria (1-3): ");
categoria = int.Parse(Console.ReadLine());

switch (categoria)
{
    case 1:
    valorfinal = valor * 0.90;
    break;

    case 2:
    valorfinal = valor * 0.85;
    break;

    case 3:
    valorfinal = valor * 0.80;
    break;

    default :
    valorfinal = valor;
    Console.WriteLine("AVISO! categoria sem desconto.");
    break;
}
Console.WriteLine($"Valor original: R$ {valor}");
Console.WriteLine($"Valor com desconto: R$ {valorfinal}");