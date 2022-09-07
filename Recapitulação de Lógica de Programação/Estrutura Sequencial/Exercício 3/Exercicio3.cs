// See https://aka.ms/new-console-template for more information
int a, b, c, d, diferenca;

Console.Write("Insira o valor de A: ");
a = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de B: ");
b = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de C: ");
c = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de D: ");
d = int.Parse(Console.ReadLine());

diferenca = (a * b - c * d);

Console.WriteLine("DIFERENCA = " + diferenca);
