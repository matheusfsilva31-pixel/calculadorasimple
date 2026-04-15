

double A;
double B;
double C;

Console.WriteLine("Digite o valor de A "); 
A =double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B ");
 B = double.Parse(Console.ReadLine());

  Console.WriteLine("Digite o valor de C ");
   C = double.Parse(Console.ReadLine());

  if(A==B && B == C)
{
    Console.WriteLine("triangulo equilatero.");
}
else if(A == B || A == C || B == C)
{
     Console.WriteLine("triangulo isòscele.");
}
else
{
    Console.WriteLine("triangulo escaleno.");
}