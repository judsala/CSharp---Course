using System.Globalization;

//Exercício 1

int number = int.Parse(Console.ReadLine());

if (number >= 0)
    Console.WriteLine("Não negativo");
else
    Console.WriteLine("Negativo");

//Exercício 2

int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("PAR");
else
    Console.WriteLine("IMPAR");

//Exercício 3

int A, B;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

if ((A % B == 0) || (B % A == 0))
    Console.WriteLine("São Múltiplos");
else
    Console.WriteLine("Não são múltiplos");

//Exercício 4

string[] horas = Console.ReadLine().Split(' ');
int inicio = int.Parse(horas[0]);
int fim = int.Parse(horas[1]);

int duracao;

if (inicio < fim)
    duracao = fim - inicio;
else
    duracao = 24 - inicio + fim;

Console.WriteLine("O jogo durou " + duracao + " horas.");

//Exercício 5

string[] codQtdd = Console.ReadLine().Split(' ');
int codigo = int.Parse(codQtdd[0]);
int quantidade = int.Parse(codQtdd[1]);

double total;
if (codigo == 1)
{
    total = quantidade * 4.0;
}
else if (codigo == 2)
{
    total = quantidade * 4.5;
}
else if (codigo == 3)
{
    total = quantidade * 5.0;
}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else
{
    total = quantidade * 1.5;
}
Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
