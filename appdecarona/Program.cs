Console.Write("digite o valor da corrida: ");
double valorcorrida = double.Parse(Console.ReadLine());

Console.Write("digite quanto voce tem de saldo: ");
double saldo = double.Parse(Console.ReadLine());

if (saldo >= valorcorrida)
{
    Console.WriteLine("corrida aceita motorista a caminho.");

}

else
{
    Console.WriteLine("saldo insuficiente recarregue sua conta.");
}