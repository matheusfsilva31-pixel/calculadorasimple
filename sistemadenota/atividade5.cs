float temperatura;

Console.WriteLine("Digite a temperatura");
temperatura = float.Parse(Console.ReadLine());

if(temperatura <= 15)
{
    Console.WriteLine("ATIVAR AQUECEDOR");
}
else if(temperatura >= 15 && temperatura < 25)
{
    Console.WriteLine("TEMPERATURA IDEAL");
}
else
{
    Console.WriteLine("ATIVAR RESFRIAMENTO.");
}