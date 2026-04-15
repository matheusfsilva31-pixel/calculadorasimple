using System;

public class vetorcomfor
{
    public static void Main()
    {
        int[] numeros = [10,20,30];
        int posicao = 2;

        Console.WriteLine($"Direto na posição [{posicao}] esta o valor: {numeros[posicao]}");

        Console.WriteLine("\nUsando FOR:");

        for (int i = 0; i < numeros.Length; i++)
        {
        Console.WriteLine($"posição [{i}] tem o valor: {numeros[i]}");
        
        }
    }
}