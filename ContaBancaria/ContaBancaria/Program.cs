using ContaBancaria;
using System.Globalization;

Conta conta;

Console.Write("Entre com o número da conta: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Entre com o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
char resp = char.Parse(Console.ReadLine());

if (resp == 's' || resp == 'S')
{
    Console.Write("Entre com o valor inicial: ");
    double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    conta = new Conta(numero, titular, valorInicial);
    Console.WriteLine(conta);
}
else
{
    conta = new Conta(numero, titular);
}

Console.WriteLine();
Console.WriteLine("Dados da conta:");
Console.WriteLine(conta);
Console.WriteLine();

Console.Write("Entre com um valor para depósito: ");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Deposito(deposito);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);

Console.WriteLine();
Console.Write("Entre com um valor para saque: ");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
conta.Saque(saque);
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
