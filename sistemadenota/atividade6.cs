double peso;
double altura;

Console.WriteLine("Digite o peso (kg): ");
peso = double.Parse(Console.ReadLine());

Console.Write("Digite sua altura (m): ");
 altura = Double.Parse (Console.ReadLine());
double imc = peso / (altura * altura);
Console.WriteLine($"Seu IMC é: {imc:F2}"); 

if(imc < 18.5)
{
    Console.WriteLine("Categoria: ABAIXO DO PESO");

}
else if (imc >= 18.5 && imc < 25)
{
    Console.WriteLine("Categoria: PESO NORMAL");
}
else
{
    Console.WriteLine("Categoria: Sobrepeso");
}

        