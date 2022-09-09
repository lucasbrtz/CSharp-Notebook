// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Write("Insira o código, a quantidade e o valor da primeira peça: ");
string[] a = Console.ReadLine().Split(' ');
int codigo1 = int.Parse(a[0]);
int quantidade1 = int.Parse(a[1]);
double valor1 = double.Parse(a[2], CultureInfo.InvariantCulture);

Console.Write("Insira o código, a quantidade e o valor da segunda peça: ");
string[] b = Console.ReadLine().Split(' ');
int codigo2 = int.Parse(b[0]);
int quantidade2 = int.Parse(b[1]);
double valor2 = double.Parse(b[2], CultureInfo.InvariantCulture);

double total = quantidade1 * valor1 + quantidade2 * valor2;

Console.WriteLine("VALOR A PAGAR: " + total.ToString("F2", CultureInfo.InvariantCulture));
