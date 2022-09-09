// See https://aka.ms/new-console-template for more information
using System.Globalization;
double x, y;

Console.Write("Insira os valores de x e y, respectivamente: ");
string[] valores = Console.ReadLine().Split(' ');
x = double.Parse(valores[0], CultureInfo.InvariantCulture);
y = double.Parse(valores[1], CultureInfo.InvariantCulture);

if (x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
else if (x == 0 && y != 0)
{
    Console.WriteLine("Eixo X");
}
else if (x != 0 && y == 0)
{
    Console.WriteLine("Eixo Y");
}
else
{
    Console.WriteLine("Origem");
}
