Console.Write("informe o perfil (professor ou aluno): ");
string perfil = Console.ReadLine();

Console.Write("esta no horario de aula? (trur/false): ");
boll estaNoHorario = boll.Parse(Console.ReadLine());

if (perfil == "professor" ||(perfil == "aluno" && estaNoHorario == true))
{
     Console.WriteLine("\n ACESSO LIBERADO");
}  
else
{
    Console.WriteLine("\n ACESSO NEGADO");
}