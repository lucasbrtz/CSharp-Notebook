// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número inteiro não-negativo: ");
int n = int.Parse(Console.ReadLine());

int fatorial = 1;
if (n != 0)
{
    for (int i = 1; i <= n; i++)
    {
        fatorial *= i;
    }
}

Console.WriteLine($"O fatorial de {n} é {fatorial}.");
