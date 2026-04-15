using System;

public class Vetor_Recebendo_valor
{
    public static void Main()
    {
        int[] numero = new int[3];

        for (int i = 0; i < numero.Length; i++)
        {
            Console.Write($"Digite o valor para posição [{i}]: ");
            numero[i] = int.Parse(Console.ReadLine());

            Console.WriteLine($"posição [{i}] = {numero[i]}");
        }
    }
}