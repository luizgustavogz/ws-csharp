using System;
using System.Globalization;

namespace Course12_DateTime {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2020, 11, 25);
            DateTime d2 = new DateTime(2020, 11, 25, 20, 45, 03);
            DateTime d3 = new DateTime(2020, 11, 25, 20, 45, 03, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2020-07-05");
            DateTime d8 = DateTime.Parse("2020-07-05 13:05:58");
            DateTime d9 = DateTime.Parse("05/07/2020");
            DateTime d10 = DateTime.Parse("05/07/2020 13:05:58");

            DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3 + "\n");
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6 + "\n");
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10 + "\n");
            Console.WriteLine(d11);
            Console.WriteLine(d12);
        }
    }
}
