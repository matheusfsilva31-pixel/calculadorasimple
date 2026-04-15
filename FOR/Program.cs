//Declaraçao de variaveis
int x;
int r;
int cont; 

//Estrutarua de repetiçao
for (cont = 1; cont <= 4; cont++)
{
    x = int.Parse(Console.ReadLine());
     
    r = x *  12;

    Console.WriteLine(r);
}