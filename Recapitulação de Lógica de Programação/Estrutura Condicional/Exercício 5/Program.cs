// See https://aka.ms/new-console-template for more information
using System.Globalization;
int codigo, quantidade;
double total;

Console.Write("Insira a o código do item e a quantidade: ");
string[] entradas = Console.ReadLine().Split(' ');
codigo = int.Parse(entradas[0]);
quantidade = int.Parse(entradas[1]);

if (codigo == 1)
{
    total = 4.00 * quantidade;
}
else if (codigo == 2)
{
    total = 4.50 * quantidade;
}
else if (codigo == 3)
{
    total = 5.00 * quantidade;
}
else if (codigo == 4)
{
    total = 2.00 * quantidade;
}
else
{
    total = 1.50 * quantidade;
}

Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
