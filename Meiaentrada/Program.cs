

Console.Write("Digite o valor do ingresso: ");
double valor = double.Parse(Console.ReadLine());

Console.Write("Digite a idade: ");
int idade = int.Parse(Console.ReadLine());

if (idade <= 18)
{
    Console.WriteLine($"Você tem {idade} anos, vai pagar {valor/2} no ingresso.");
}

else
{
    Console.WriteLine($"Você tem {idade} anos, vai pagar {valor} no ingresso.");
}