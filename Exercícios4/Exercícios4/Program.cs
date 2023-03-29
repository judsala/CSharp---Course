//Exercício 1
using System.Globalization;

int value = int.Parse(Console.ReadLine());

for (int i = 0; i <= value; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

//Exercício 2

int N = int.Parse(Console.ReadLine());
int dentro = 0, fora = 0;

for (int i = 0; i < N; i++)
{
    int X = int.Parse(Console.ReadLine());
    if (X >= 10 && X <= 20)
    {
        dentro++;
    }
    else
    {
        fora++;
    }
}
Console.WriteLine(dentro + "in");
Console.WriteLine(fora + "out");

//Exercício 3

int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
    double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
    double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
    double resultado = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / 10.0;

    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
}

//Exercício 4

int N = int.Parse(Console.ReadLine());

for (int i = 0;i < N; i++)
{
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    if (b == 0)
    {
        Console.WriteLine("Divisão impossível!");
    }
    else
    {
        double resultado = (double)a / b;
        Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
    }
}

//Exercício 5

int N = int.Parse(Console.ReadLine());
int fat = 1;

for (int i = 1; i <= N; i++)
{
    fat = fat * i;
}
Console.WriteLine(fat);

//Exercício 6

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (N % i == 0) 
        Console.WriteLine(i);
}

//Exercício 7

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    int linha = i;
    int square = i * i;
    int cube = i * i * i;
    Console.WriteLine($"{linha} {square} {cube}");
}
