string exercicio;
int total;
int atual;

Console.Write(" o nome do exercicio ?");
 exercicio = Console.ReadLine();

 Console.Write(" Quantas repetiçoes você vai fazer? ");
 total = int.Parse(Console.ReadLine());

for(atual = 1; atual <= total; atual++)
{
    Console.WriteLine($"Fazendo {exercicio} + {atual} de = {total}.");
}
Console.WriteLine("serie concluida! descanso iniciando.");


    


