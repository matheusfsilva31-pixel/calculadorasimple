double n1, n2, resultado;
string operacao;

Console.Write("Digite o primeiro numero: ");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero: ");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a operaçao (+, -, *, /):");
operacao = Console.ReadLine();

switch (operacao)
{
    case "+":
    resultado = n1 + n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;
    
     case "-":
    resultado = n1 - n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

     case "*":
    resultado = n1 * n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

     case "/":
    resultado = n1 / n2;
    Console.WriteLine("Resultado: "+ resultado);
    break;

    default :
    Console.WriteLine("operaçao invalida. ");
    break;

}
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();


