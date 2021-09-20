using System;
using ExcParadigmas.Tipos;

namespace ExcParadigmas {
    class Program {
        static void Main(string[] args) {

            Animal a1 = new Herbivore("Rabbit");
            Animal a2 = new Carnivore("Lion");
            Animal a3 = new Carnivore("Hyena");
            Animal a4 = new Omnivore("Man");

            Console.WriteLine("Herbivores: " + a1.Nome);
            Console.WriteLine("Carnivores: " + a2.Nome + " and " + a3.Nome);
            Console.WriteLine("Omnivores: " + a4.Nome);
        }
    }
}
