using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Maria";
            int age = 32;
            double balance = 10.35784;

            Console.WriteLine("{0}, {1} anos. Saldo: {2:F2} reais", name, age, balance);

            Console.WriteLine($"{name}, {age} anos. Saldo: {balance:F2} reais");

            /*Console.WriteLine(balance.ToString("F2"));   // Formatando quantas casas decimais
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture)); // Colocando o .
            */
        }
    }
}
