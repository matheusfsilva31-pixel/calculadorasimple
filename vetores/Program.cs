using System;
using System.ComponentModel;

class program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] notas = new double[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"---CADASTRO DO {i + i}° aluno---");
            Console.Write("nome: ");
            nomes[1] = Console.ReadLine();

            Console.Write($"Nota de {nomes[1]}:");
            notas[1] = double.Parse(Console.ReadLine());

            Console.WriteLine();
    
        }
        Console.WriteLine("\n==== BOLETIM ESCOLAR====");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Aluno: {nomes[1].PadRight[10]} ! nota: {notas[i]:F1}");
        }

    }
}

