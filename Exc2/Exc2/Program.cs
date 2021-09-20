using System;
using System.Globalization;

namespace Exc2 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, quantity);

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProducts(qte);

            Console.WriteLine("\nDados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removido ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProducts(qte);

            Console.WriteLine("\nDados atualizados: " + p);
        }
    }
}
