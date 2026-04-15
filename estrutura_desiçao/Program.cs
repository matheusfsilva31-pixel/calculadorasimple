// 1. Entradas de Dados
Console.Write("Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a Segunda nota: ");
double nota2 = double.Parse(Console.ReadLine());
// Calculo da media
double media = (nota1 + nota2);

// Estrutura de Deciçao
if (media >= 7)
{
    Console.WriteLine("Aprovado! media: " + media);
}
else
{
    Console.WriteLine("Reprovado. Media: " + media);
}
