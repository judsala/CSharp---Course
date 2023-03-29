using System;
using Course.Entities;
using System.Globalization;
using Course.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

Client client = new Client(name, email, birthDate);
Order order = new Order(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string prodName = Console.ReadLine();
    Console.Write("Product price: ");
    double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product prod = new Product(prodName, prodPrice);

    Console.Write("Quantity: ");
    int qtd = int.Parse(Console.ReadLine());

    OrderItem orderItem = new OrderItem(qtd, prodPrice, prod);
    order.AddItem(orderItem);
}

    Console.WriteLine();
    Console.WriteLine("Order Summary:");
    Console.WriteLine(order);
