int peças = 0;
Console.WriteLine("Digite a quantidade de peças");
 peças = int.Parse(Console.ReadLine());
int contador =0;
while(contador < peças)
{
    contador++;
    Console.WriteLine("peças" + contador + "processada.");
}

