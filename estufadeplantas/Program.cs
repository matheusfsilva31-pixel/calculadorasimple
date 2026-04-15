Console.Write("Digite qual a temperatura da estufa: ");
double temperatura = double.Parse(Console.ReadLine());

if (temperatura > 30)
{
    Console.WriteLine($"ligar ventilador!. ");
}

else
{
    Console.WriteLine($"temperatura OK. ");
}