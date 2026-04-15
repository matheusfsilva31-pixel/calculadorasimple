int vidaDragao = 100;
int escolha;
int turno;
int danoGerado;

Console.WriteLine("=== DESAFIO DO DRAGÃo ===");
Console.WriteLine("você tem 5 truno para derrotar a fera!");

// inicio do laço for
for (turno = 1; turno <= 5; turno++)
{
    Console.WriteLine("\n------------------------");
    Console.WriteLine($"TURNO {turno} | VIDA DO DRAGÂO: {vidaDragao}HP");
    Console.WriteLine("(1) ataque com espada");
    Console.WriteLine("(2) lança magia");
    Console.WriteLine("[3] cura");
    escolha = int.Parse(Console.ReadLine());

    if(escolha == 1)
    {
        danoGerado = 20;
        vidaDragao = vidaDragao - danoGerado;
        Console.WriteLine($"você golpeou o dragão {danoGerado} de dano");

    }
    else if (escolha == 2)
    {
        danoGerado = 35;
        vidaDragao = vidaDragao - danoGerado;
        Console.WriteLine($"magia poderosa! causou {danoGerado} de dano ao dragão");
    }
    else
    {
        Console.WriteLine("você se curou, mas o dragão riu de você!");
    }

    //verifica se o Dragão foi derrotado
    if (vidaDragao <= 0)
    {
        Console.WriteLine("O Dragão morreu!");
        break;
    }

}
if (vidaDragao > 0)
{
    Console.WriteLine("O tempo acabou. o dragão te derrotou!");
} 






    


