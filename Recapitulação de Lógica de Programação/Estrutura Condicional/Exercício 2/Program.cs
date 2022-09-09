// See https://aka.ms/new-console-template for more information
Console.Write("Insira um número inteiro: ");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {
    Console.WriteLine("PAR");
}
else {
    Console.WriteLine("IMPAR");
}
