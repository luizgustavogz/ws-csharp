using System;
using System.Globalization;

namespace Course3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double alt = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("\nVocê digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome + ", " + sexo + ", " + idade + " anos, " + alt.ToString("F2", CultureInfo.InvariantCulture) + "m");
        }
    }
}
