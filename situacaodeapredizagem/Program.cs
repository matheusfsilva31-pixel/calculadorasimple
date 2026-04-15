using System;
namespace clima
{
    class Program
    {
        static void Main()
        {
            float[] clima = new float[3];
            

            if(clima[0] < 20)
            {
                Console.WriteLine("Cidade 1: esta frio!");
                
                
            }
             else if(clima[0] <= 25)
            {
                Console.WriteLine("Cidade 1: esta agradavel!");
                
                
                
            }
            else
            {
                Console.WriteLine("Cidade 1: Esta quente!");
                
            }

            

        }    
        
            
        
    }
}



