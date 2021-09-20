using System;
using Course37_Delegate_Func.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course37_Delegate_Func {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /* Lambda:
                Func<Product, string> func = p => p.Name.toUpper();
                List<string> result = list.Select(func).ToList();

               Declarando Delegate:
                Func<Product, string> func = NameUpper;
                List<string> result = list.Select(func).ToList();
            */


            List<string> result = list.Select(NameUpper).ToList();
            foreach (String s in result) {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}
