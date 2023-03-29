//Exercício 1

int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Inválida!");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");

//Exercício 2

string[] valores = Console.ReadLine().Split(' ');
int x = int.Parse(valores[0]);
int y = int.Parse(valores[1]);

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("quarto");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("segundo");
    }
    valores = Console.ReadLine().Split(' ');
    x = int.Parse(valores[0]);
    y = int.Parse(valores[1]);
}

//Exercício 3

int codigo = int.Parse(Console.ReadLine());
int alcool = 0, gasolina = 0, diesel = 0;

while (codigo != 4)
{
    if (codigo == 1)
    {
        alcool++;
    }
    else if (codigo == 2)
    {
        gasolina++;
    }
    else if (codigo == 3)
    {
        diesel++;
    }
    codigo = int.Parse(Console.ReadLine());
}
Console.WriteLine("MUITO OBRIGADA!");
Console.WriteLine("Álcool: " + alcool);
Console.WriteLine("Gasolina: " + gasolina);
Console.WriteLine("Diesel: " + diesel);

