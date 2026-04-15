Console.Write("digite a idade do atleta: ");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("categoria adulto.");
}
else if (idade >= 13)
{
    Console.WriteLine("categoria juvenil.");
}
else if (idade >= 5)
{
    Console.WriteLine("categoria infantil.");
}
else
{
    Console.WriteLine("idade insuficiente para competir.");
}