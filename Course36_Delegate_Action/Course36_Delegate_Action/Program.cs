using System;
using Course36_Delegate_Action.Entities;
using System.Collections.Generic;

namespace Course36_Delegate_Action {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /* Lambda:
               Action<Product> act = p => { p.Price += p.Price * 0.1; };
               list.ForEach(act); 

               Variável tipo referência:
               Action<Product> act = UpdatePrice;
               list.ForEach(act); 
            */

            list.ForEach(UpdatePrice); // Delegate Action
            foreach(Product p in list) {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }
    }
}
