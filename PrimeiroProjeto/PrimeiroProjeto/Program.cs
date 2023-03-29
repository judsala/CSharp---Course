using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double number = 12.426478;
            //Console.WriteLine(number.ToString("F2"));
            //Console.WriteLine(number.ToString("F2", CultureInfo.InvariantCulture));

            int number = 123456;

            string stringNumber = number.ToString();
            int newNumbe;
            int soma = 0;
            for(int i = 0; i < stringNumber.Length; i++)
            {
                newNumbe = Convert.ToInt32(stringNumber[i] - '0');
                soma += newNumbe;
            }
            Console.WriteLine(soma);
        }
    }
}
