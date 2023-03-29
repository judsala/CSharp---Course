using System.Globalization;

//Exercício 1

int n1, n2, soma;

n1 = int.Parse(Console.ReadLine());
n2 = int.Parse(Console.ReadLine());

soma = n1 + n2;

Console.WriteLine("Soma = " + soma);

//Exercício 2

double area, raio, pi;

raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
pi = 3.14159;

area = pi * (Math.Pow(raio, 2));

Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

//Exercício 3

int A, B, C, D, diferenca;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

diferenca = (A * B - C * D);

Console.WriteLine("DIFERENÇA = " + diferenca);

//Exercício 4

int number, workTime;
double salary, workValue;

number = int.Parse(Console.ReadLine());
workTime= int.Parse(Console.ReadLine());
workValue= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

salary = workTime * workValue;

Console.WriteLine("NUMBER = " + number + '\n' + "SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

//Exercício 5

int id1, id2, qtdPeca1, qtdPeca2;
double valor1, valor2, total;

string[] valores = Console.ReadLine().Split(' ');
id1 = int.Parse(valores[0]);
qtdPeca1 = int.Parse(valores[1]);
valor1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

valores = Console.ReadLine().Split(' ');
id2 = int.Parse(valores[0]);
qtdPeca2 = int.Parse(valores[1]);
valor2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

total = qtdPeca1 * valor1 + qtdPeca2 * valor2;

Console.WriteLine("VALOR A PAGAR: " + total.ToString("F2", CultureInfo.InvariantCulture));




