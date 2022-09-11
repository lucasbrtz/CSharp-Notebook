// See https://aka.ms/new-console-template for more information
using System.Globalization;

Console.Write("Digite a senha: ");
int x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

while (x != 2002)
{
    Console.WriteLine("Senha Inválida");
    Console.Write("Digite a senha: ");
    x = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

Console.WriteLine("Acesso Permitido");
