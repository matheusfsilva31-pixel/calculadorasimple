double precoDoProduto;
double contatotal = 0;
int codigoDaCategoria;
int produtoAtual;

Console.WriteLine("===BEM VINDO A LANCHONETE ESCOLA SENAI BARRA FUNDA===");
for  (produtoAtual = 1; produtoAtual <=5; produtoAtual++)
{
    Console.WriteLine("PASSANDO O PRODUTO NUMERO: "+ produtoAtual);

    Console.WriteLine("Qual o preço desse produto? R$ ");
    precoDoProduto = double.Parse(Console.ReadLine());

    Console.WriteLine("categoria: 1-Limpeza | 2- Alimento | 3-Eletronico");
    Console.Write("Qual o codigo da categoria? ");
    codigoDaCategoria = int.Parse(Console.ReadLine());
    switch (codigoDaCategoria)
    {
        case 1:
        case 2:
           contatotal = contatotal + precoDoProduto;
           Console.WriteLine("produto comum somado.");
           break;
        case 3:
            
             contatotal = contatotal + (precoDoProduto * 1.80);
             Console.WriteLine("Eletronico somado com taxa de 10%");
             break;
        default:
           Console.WriteLine("codigo errado!");
           break;   
    }

}
Console.WriteLine("VALOR TOTAL PARA PAGAR: R$ " + contatotal);