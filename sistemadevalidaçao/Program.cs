string senai123;

Console.Write("Digite a senha");
senai123 = Console.ReadLine();
while (senai123 != "senai123") ;
{
    Console.WriteLine("senha incorreta, tente novamente.");
    Console.Write("Digite a senha: ");
    senai123 = Console.ReadLine();
}
Console.WriteLine("acesso concedido.");