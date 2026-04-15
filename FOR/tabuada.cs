int tabuada;
int resultado;
int mutiplicador;

Console.Write("Digite o numero da tabuada: ");
tabuada = int.Parse(Console.ReadLine());
for (mutiplicador = 1; mutiplicador <=10; mutiplicador++) 
{
    resultado = tabuada*mutiplicador;
    Console.WriteLine($"{tabuada} X {mutiplicador} = {resultado}");
} 

