using System;

namespace verificacao
{
    class Program
    {
        static void Main()
        {
            int[] estoque = new int[5];
            int i =0;

            Console.WriteLine("Qual a quantidade de uma das 5 caixas");

            while(i < estoque.Length)
            {
                Console.Write($"Caixa {i+1}: ");
                estoque[1] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            for(int i =0; i < estoque.Length; i++)
            {
                if (estoque[i] < 10)
                {
                    Console.WriteLine($"Caixa {i+1}: Reposição Necessaria!");
                }
                else
                {
                    Console.WriteLine($"Caixa {i + 1}: Estoque OK");
                }

            }
            
        }
    }
}
