// See https://aka.ms/new-console-template for more information
Console.Write("Insira a quantidade de números a serem lidos: ");
int quantidade = int.Parse(Console.ReadLine());

int dentro = 0, fora = 0;
for (var i = 0; i < quantidade; i++)
{
    Console.Write("Insira um número: ");
    int num = int.Parse(Console.ReadLine());
    if (num >= 10 && num <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}

Console.WriteLine($"{dentro} in");
Console.WriteLine($"{fora} out");
