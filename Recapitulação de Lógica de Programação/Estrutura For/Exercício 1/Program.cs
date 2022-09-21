// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número: ");
int num = int.Parse(Console.ReadLine());

for (var i = 0; i <= num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
