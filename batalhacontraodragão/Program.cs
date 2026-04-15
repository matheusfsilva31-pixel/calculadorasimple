using System;
class program;

    



int vidaDragao = 100;
int vidajogador = 100;

for(int turno =1;turno <= 5; turno++)
{
    Console.WriteLine($"\n--- turno {turno}---");
    Console.WriteLine("escolha sua ação:");
    Console.WriteLine("1- atacar");
    Console.WriteLine("2- defender");
     
     int escolha = Console.ReadLine();
     if (escolha ==1);
} 
    vidaDragao -= 20;
    Console.WriteLine("você atacou o dragão! -20 de vida.");

    else if (escolha == 2)
{
    Console.WriteLine("você se defende! o dragão causo menos dano.");
    vidajogador -= 5;
}
else
{
    Console.WriteLine("açao invalida! você perdeu a vez.");
}
    //Dragâo ataca se estiver vivo
    if (vidaDragao > 0 && escolha == 1) ;
{
    vidajogador -= 15;
    Console.WriteLine("O dragão atacou você! -15 de vida.");
}
    Console.WriteLine($"vida do dragão: {vidaDragao}");
    Console.WriteLine($"sua vida: {vidajogador}");

    if (vidaDragao <= 0)
{
    Console.WriteLine("você derrotou o dragão!");
    break;
}
    if (vidajogador <= 0)
{
    Console.WriteLine("você foi derrotado pelo dragão ");
     break; 
}
  Console.WriteLine("\nfim do jogo!");   







