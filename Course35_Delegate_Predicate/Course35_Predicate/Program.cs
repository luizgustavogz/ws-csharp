using System;
using Course35_Predicate.Entities;
using System.Collections.Generic;

namespace Course35_Predicate {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest); // Delegate Predicate
            foreach (Product p in list) {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p) {
            return p.Price >= 100.0;
        }
    }
}
