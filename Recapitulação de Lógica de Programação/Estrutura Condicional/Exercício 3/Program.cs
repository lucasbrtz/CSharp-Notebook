// See https://aka.ms/new-console-template for more information
Console.Write("Insira os valores de A e B: ");
int a, b;
string[] valores = Console.ReadLine().Split(' ');
a = int.Parse(valores[0]);
b = int.Parse(valores[1]);

if (a % b == 0 || b % a == 0)
{
    Console.WriteLine("São múltiplos");
}
else
{
    Console.WriteLine("Não são múltiplos");
}
