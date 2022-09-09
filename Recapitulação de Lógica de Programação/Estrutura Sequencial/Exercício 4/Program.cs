// See https://aka.ms/new-console-template for more information
using System.Globalization;

int codigo, horas;
double valor, salario;

Console.Write("Insira o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Insira o número de horas trabalhadas do funcionário: ");
horas = int.Parse(Console.ReadLine());
Console.Write("Insira o valor que o funcionário recebe por hora: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salario = horas * valor;

Console.WriteLine($"NUMBER: {codigo}");
Console.WriteLine("SALARY: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
