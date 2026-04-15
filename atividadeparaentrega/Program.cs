double salario = 0;
int tempo;

Console.WriteLine("Digite o salario do funcionario");
salario = double.Parse(Console.WriteLine());
Console.WriteLine("Digite o tempo de serviço do funcionario (EM ANOS)");
tempo = int.Parse(Console.ReadLine());

if (tempo > 10)
{
    salario += salario * 0.20;
    Console.WriteLine("O salario do funcionario é: R$ " + salario);
}
else if (tempo >= 5 && tempo <= 10)
{
    salario += salario * 0.10;
    Console.WriteLine("O Salario do funcionario é: R$ " + salario);
}
else
{
    salario += * 0.05;
    Console.WriteLine("O salario do funcionario é: R$ " + salario);
}
