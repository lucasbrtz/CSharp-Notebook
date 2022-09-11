// See https://aka.ms/new-console-template for more information
Console.Write("Insira os valores de x e y: ");
string[] valores = Console.ReadLine().Split(' ');
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Primeiro Quadrante");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Segundo Quadrante");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro Quadrante");
    }
    else
    {
        Console.WriteLine("Quarto Quadrante");
    }

    Console.Write("Insira os valores de x e y: ");
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
}
