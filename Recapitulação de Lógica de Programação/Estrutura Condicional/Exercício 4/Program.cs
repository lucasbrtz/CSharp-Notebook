// See https://aka.ms/new-console-template for more information
int inicio, fim, duracao;

Console.Write("Insira os horários de início e fim do jogo: ");
string[] horarios = Console.ReadLine().Split(' ');
inicio = int.Parse(horarios[0]);
fim = int.Parse(horarios[1]);

if (inicio < fim)
{
    duracao = fim - inicio;
}
else
{
    duracao = 24 - inicio + fim;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
