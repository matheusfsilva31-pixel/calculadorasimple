using System;

class ControleEstoque
{
    static void Main()
    {
        
        int[,] estoque = new int[2, 2];

        
        estoque[0, 0] = 15; 
        estoque[0, 1] = 20; 
        estoque[1, 0] = 10; 
        estoque[1, 1] = 30; 

        
        int totalInferior = estoque[1, 0] + estoque[1, 1];

        
        Console.WriteLine("Total de componentes na prateleira inferior: " + totalInferior);
    }
}
