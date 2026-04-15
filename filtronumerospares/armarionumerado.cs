using System;
namespace armario
{
    class program
    {
        static void Main()
        {
            string[] nomes = new string[3];
            

            Console.WriteLine("Digite o primeiro nomes:");
            nomes [0] = Console.ReadLine();

            Console.WriteLine("Digite o segundo numero: ");
            nomes [1] = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nomes: ");
            nomes [2] = Console.ReadLine();

            Console.WriteLine("Os nomes guardados foram: ");
            Console.WriteLine($"Nomes{nomes[0]}");
             Console.WriteLine($"Nomes{nomes[1]}");
              Console.WriteLine($"Nomes{nomes[2]}");
            
    
        }
    }
}

