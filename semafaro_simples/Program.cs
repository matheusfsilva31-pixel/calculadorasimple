Console.Write("digite qual a cor do semáfaro(verde/amarelo/vermelho): ");
string cor = Console.ReadLine();

if (cor == "verde")
{
    Console.WriteLine("siga em frente.");
}   
else  if(cor == "amarelo")
{
    Console.WriteLine("atenção:reduza a velocidade. ");
}        
else 
{
    Console.WriteLine("erro: cor invalida");
}
