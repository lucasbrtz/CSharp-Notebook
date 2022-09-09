// See https://aka.ms/new-console-template for more information
using System.Globalization;

double salario, imposto = 0;

Console.Write("Insira o salário: ");
salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if (salario > 2000 && salario <= 3000)
{
    imposto = salario * 0.08;
    Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
}
else if (salario > 3000 && salario <= 4500)
{
    imposto = (salario - 3000) * 0.18 + 80;
    Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
}
else if (salario > 4500)
{
    imposto = (salario - 4500) * 0.28 + 80 + 270;
    Console.WriteLine("R$" + imposto.ToString("F2", CultureInfo.InvariantCulture));
}
else
{
    Console.WriteLine("Isento");
}
