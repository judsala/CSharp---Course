using System;
using System.ComponentModel.Design;
using System.Globalization;

double preco = double.Parse(Console.ReadLine());

/* double desconto;

if (preco < 20)
{
    desconto = preco * 0.1;
}
else
{
    desconto = preco * 0.05;
}

Console.WriteLine(desconto);*/

// Mesmo código utilizando ternário

                   //condição   se      true        false   
double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

Console.WriteLine(desconto);

string str = "Eve Cristina Sala Platt     ";

string s1 = str.Trim();

Console.WriteLine(s1 + "-");

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

