double total = 0;
double valorvenda = 1;
while(valorvenda < 0)
{
    Console.WriteLine("digite um valor ou '0'para encerrar: ");
    valorvenda = double.Parse(Console.ReadLine());
    total += valorvenda;
}
Console.WriteLine($"encerrando o programa. Valor total das vendas: R$ {total}");    


