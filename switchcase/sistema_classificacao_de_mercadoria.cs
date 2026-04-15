double preco;
int codigodeorigem;
string origem;

Console.WriteLine("informe o valor do produto: R$ ");
preco = double.Parse(Console.ReadLine());

Console.WriteLine("digite o codigo de origem.");
int codigodeorigem = int.Parse(Console.WriteLine());

switch (codigodeorigem)
{
    case 1 :
    origem = "sul";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 2 :
    origem = "norte";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 3:
    origem = "leste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 4:
    origem= "oeste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 5 :
    case 6 :
    origem = "nordeste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 7 :
    case 8 :
    case 9 :
    origem = "sudeste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 10 :
    codigodeorigem = "centrooeste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    case 11 :
    origem = "noroeste";
    Console.WriteLine(codigodeorigem + preco);
    break;

    default :
    Console.WriteLine("IMPORTADO!!! CODIGO INVALIDO");
    break;

}
