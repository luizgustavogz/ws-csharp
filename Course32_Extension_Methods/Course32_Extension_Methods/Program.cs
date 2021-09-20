using System;

namespace Course32_Extension_Methods {
    class Program {
        static void Main(string[] args) {

            DateTime dt = new DateTime(2021, 3, 16, 8, 10, 45);
            DateTime dt1 = new DateTime(2021, 5, 24, 8, 10, 45);

            Console.WriteLine("-- DateTime Extension Example --");
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine(dt1.ElapsedTime());

            Console.WriteLine("\n-- Cut String Extension Example --");
            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
