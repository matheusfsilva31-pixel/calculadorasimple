int porcetagem;
int cont;

Console.WriteLine("iniciando a intalação...");

for (cont = 1; cont <= 10; cont++)
{
    porcetagem = cont * 10;
    Console.WriteLine($"Processo {porcetagem}%");
}
Console.WriteLine("\n sistema instalado com sucesso!");  