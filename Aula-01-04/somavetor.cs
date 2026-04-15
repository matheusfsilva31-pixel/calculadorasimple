public class somavetor
{
    public static void Main()
    {
        int[] numeros = new int[5];
        int soma = 0;

        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor para posição [{i}]: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }

        
        Console.WriteLine("\nValores digitados:");
         for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Posição [{i}] = {numeros[i]}");
        }

        Console.WriteLine($"\nSoma total: {soma}");
    }
}
        
    
