using Pensionato;

Estudante[] std = new Estudante[10];

Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Rent #{i}: ");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Room: ");
    int room = int.Parse(Console.ReadLine());
    std[room] = new Estudante(nome, email);
}
Console.WriteLine();
Console.WriteLine("Busy rooms: ");
for (int i = 0 ; i < 10; i++)
{
    if (std[i] != null)
    {
        Console.WriteLine(i + ": " + std[i]);
    }
}

