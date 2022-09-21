// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número inteiro: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Os divisores de {n} são:");

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
    }
}
