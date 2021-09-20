using System;

namespace Course27_Generics1 {
    class Program {
        static void Main(string[] args) {

            // Generics para o método em Int

            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First value: " + printService.First());
        }
    }
}
