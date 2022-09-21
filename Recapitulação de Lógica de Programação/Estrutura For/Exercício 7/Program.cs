// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número inteiro positivo: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine(i + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
}
