using Triangulo;

Class1 x = new Class1();

Console.WriteLine("Digite 3 notas: ");
x.A = double.Parse(Console.ReadLine());
x.B = double.Parse(Console.ReadLine());
x.C = double.Parse(Console.ReadLine());

double media = x.Calculo();

Console.WriteLine(media.ToString("F2"));

if (media >= 7)
    Console.WriteLine("Parabéns gênio, você foi aprovado!");
else
    Console.WriteLine("Sinto muito, mas você foi reprovado, seu jumento!");


