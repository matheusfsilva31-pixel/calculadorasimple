Console.Write("digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Digite a renda mensal: ");
double renda = double.Parse(Console.ReadLine());

 if (idade >= 18 && renda < 2000)
{
     Console.WriteLine("emprestimo aporvado.");
}

else if(idade >= 18 && renda < 18)
{
    Console.WriteLine("emprestimo em analise,rende insuficiente.");
}

else
{
    Console.WriteLine("emprestimo reprovado,menor de idade.");
}