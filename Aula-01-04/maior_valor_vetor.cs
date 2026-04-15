using System;

class Progam
{
    static void Main()
    {
        int[] vetor = new int[5];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Digite o valor para posição {i}:");
            vetor[i] = int.Parse(Console.ReadLine());

            int maior = vetor[0];

            for (int j = 1; j < vetor.Length; j++)
            {
                if (vetor[j] > maior)
                {
                    maior = vetor[j];
                }
            }  Console.WriteLine($"O maior valor do vetor é: {maior}");
        }
    }
}