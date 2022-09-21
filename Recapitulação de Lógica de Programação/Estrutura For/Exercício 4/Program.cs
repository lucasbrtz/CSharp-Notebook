// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Write("Insira um número: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Insira o valor do dividendo e do divisor, respectivamente: ");
    string[] valores = Console.ReadLine().Split(' ');
    double dividendo = double.Parse(valores[0], CultureInfo.InvariantCulture);
    double divisor = double.Parse(valores[1], CultureInfo.InvariantCulture);

    if (divisor != 0)
    {
        double quociente = dividendo / divisor;
        Console.WriteLine("Quociente: " + quociente.ToString("F1", CultureInfo.InvariantCulture));
    }
    else
    {
        Console.WriteLine("Divisão impossível");
    }
}
