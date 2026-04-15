using System;

class Progam
{
    static void Main()
    {
        int[] numeros = new int[3];

        Console.Write("Digite o 1° numero: ");
        numeros[0] = int.Parse(Console.ReadLine());

        Console.Write("Digite o 2° numero: ");
         numeros[1] = int.Parse(Console.ReadLine());

         Console.Write("Digite o 3° numero: ");
         numeros[2] = int.Parse(Console.ReadLine());

         Console.WriteLine("\nValor digitado: ");
         Console.WriteLine(numeros[0]);
         Console.WriteLine(numeros[1]);
         Console.WriteLine(numeros[2]);





    }
}
