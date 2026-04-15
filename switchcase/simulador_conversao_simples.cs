double valorReal;
double valorconvertido =0;
int opcao;

Console.WriteLine("Digite o valor em reais (R$)");
valorReal = double.Parse(Console.ReadLine());

Console.WriteLine("1-dollar (USD)");
Console.WriteLine("2- euro (EUR)");
Console.WriteLine("3-paso argentino (ARS)");
Console.WriteLine("4-libra (GPA)");
Console.WriteLine("escolha a moda para conbersao: ");
opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1 :
    valorconvertido = valorReal / 5.00;
    Console.WriteLine($"valor convertido {valorconvertido:F2}");
    break;

    case 2 :
    valorconvertido = valorReal / 5.50;
    Console.WriteLine($"valor convertido");
}



    









