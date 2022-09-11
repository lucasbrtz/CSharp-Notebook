// See https://aka.ms/new-console-template for more information
Console.Write("Insira o código do combustível abastecido: ");
int codigo = int.Parse(Console.ReadLine());

int alcool = 0, gasolina = 0, diesel = 0;

while (codigo != 4)
{
    if (codigo < 1)
    {
        Console.Write("Código inválido. Por favor, insira o código do combustível abastecido: ");
        codigo = int.Parse(Console.ReadLine());
    }
    else if (codigo == 1)
    {
        alcool++;
        Console.Write("Insira o código do combustível abastecido: ");
        codigo = int.Parse(Console.ReadLine());
    }
    else if (codigo == 2)
    {
        gasolina++;
        Console.Write("Insira o código do combustível abastecido: ");
        codigo = int.Parse(Console.ReadLine());
    }
    else if (codigo == 3)
    {
        diesel++;
        Console.Write("Insira o código do combustível abastecido: ");
        codigo = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.Write("Código inválido. Por favor, insira o código do combustível abastecido: ");
        codigo = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Álcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " + diesel);
