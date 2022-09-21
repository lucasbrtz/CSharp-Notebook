// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Write("Insira o número de casos de teste: ");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.Write("Insira 3 valores: ");
    string[] numeros = Console.ReadLine().Split(' ');
    double num1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
    double num2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
    double num3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);

    double media = (num1 * 2 + num2 * 3 + num3 * 5) / 10;
    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}
