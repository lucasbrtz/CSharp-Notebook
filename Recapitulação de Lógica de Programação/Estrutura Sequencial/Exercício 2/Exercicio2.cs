// See https://aka.ms/new-console-template for more information
using System.Globalization;

double r, pi, a;

Console.Write("Insira o valor do raio: ");
r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
pi = 3.14159;
a = pi * r * r;

Console.WriteLine("Área = " + a.ToString("F4", CultureInfo.InvariantCulture));
