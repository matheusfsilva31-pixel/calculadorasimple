int categoria;
double valor, valorfinal;

Console.WriteLine("informe o valor do produto: R$ ");
valor = double.Parse(Console.ReadLine());

Console.WriteLine("\nMENU DE CATEGORIA:");
Console.WriteLine("1 - Alimento");
Console.WriteLine("2 - Alimento");
Console.WriteLine("3 - Alimento");
Console.WriteLine("Escolha a categoria (1-3): ");
categoria = int.Parse(Console.ReadLine());

if (categoria == 1)
{
    valorfinal = valor * 0.90; //10% de desconto
}
else if (categoria == 2)
{
    valorfinal = valor * 0.85; //15% de desconto
}
else if(categoria == 3)
{
    valorfinal * 0.80; //20% de desconto
}
else
{
    valorfinal = valor;
    Console.WriteLine("AVISO! categoria sem desconto.");
}
Console.WriteLine($"valor original: R$ {valor}");
Console.WriteLine($"Valor com Desconto: R$ {valorfinal}");
    
