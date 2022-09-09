// See https://aka.ms/new-console-template for more information
Console.Write($"Insira um número: ");
int n = int.Parse(Console.ReadLine());

if (n >= 0)
{
    Console.WriteLine("NAO NEGATIVO");
}
else
{
    Console.WriteLine("NEGATIVO");
}
