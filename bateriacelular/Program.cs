Console.WriteLine("informe a bateria atual do celular (%)");
int bateria = int.Parse(Console.ReadLine());

while (bateria > 0) 
{
    bateria -= 10;
    if (bateria <= 0)
    {
        Console.WriteLine("bateria descarregada. O celular desligou. ");
        break; // encerra o sistema quando bate 0
    }
        Console.WriteLine("bateria carregada para: " + bateria + "%");
         if (bateria == 20)
    {
        Console.WriteLine("Alerta: bateria baixa modo de economia ativado. ");
    }
} 



    
