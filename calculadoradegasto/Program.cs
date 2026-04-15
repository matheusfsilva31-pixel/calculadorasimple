using System;

class Progam
{
    static void Main()
    {
        float[] gastosDiario = new float[5];

        int posicao = 0;
        float total = 0;

        while(posicao < 5)
        {
            Console.Write($"Digite o valor do dia {posicao}:");
            gastosDiario[posicao] = float.Parse(Console.ReadLine());

            total = total + gastosDiario[posicao];

            posicao++;
        }
        Console.WriteLine($"total de gasto na semana de {total}");
    }
}
