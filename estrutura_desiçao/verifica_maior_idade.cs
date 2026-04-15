// Entrada de Dados
Console.Write("Digite a sua idade: ");
int idade = int.Parse(Console.ReadLine());

//2. Decisão se a idade è 18 ou mais

if(idade >= 18)
{
    Console.WriteLine("Você e maior de idade." + idade);
}

else
{
    Console.WriteLine("você è menor de idade" + idade);
}