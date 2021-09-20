using System;
using System.Globalization;

namespace Course6._2_Vetores {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            Product[] p = new Product[n];

            for (int i = 0; i< n; i++) {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i<n; i++) {
                sum += p[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("\nAVERAGE PRICE = " + avg.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
