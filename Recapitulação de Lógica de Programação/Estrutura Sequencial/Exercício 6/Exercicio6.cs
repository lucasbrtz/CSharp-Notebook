﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;

double a, b, c, triangulo, circulo, trapezio, quadrado, retangulo;

Console.Write("Insira os valores e A, B e C: ");
string[] valores = Console.ReadLine().Split(' ');
a = double.Parse(valores[0], CultureInfo.InvariantCulture);
b = double.Parse(valores[1], CultureInfo.InvariantCulture);
c = double.Parse(valores[2], CultureInfo.InvariantCulture);

triangulo = (a * c) / 2;
circulo = 3.14159 * c * c;
trapezio = c * ((a + b) / 2);
quadrado = b * b;
retangulo = a * b;

Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
