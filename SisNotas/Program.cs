int nota = 0;

Console.WriteLine("Digite a nota do aluno (0 a 100):");
nota = int.Parse(Console.ReadLine());

if (nota >= 90)
{
    Console.WriteLine("Desepenho: exelente");
}
else if (nota >= 70 && nota < 90)
{
    Console.WriteLine("Desempenho: satifatorio");
}
else
{
    Console.WriteLine("Desempenho: Ainda não atingido");
}

