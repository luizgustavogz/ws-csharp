using System;
using Course29_GetHashCode_Equals.Entities;

namespace Course29_GetHashCode_Equals {
    class Program {
        static void Main(string[] args) {

            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };
            Client c = new Client { Name = "Bob", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b == c);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
