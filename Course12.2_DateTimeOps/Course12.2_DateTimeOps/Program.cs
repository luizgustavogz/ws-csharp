using System;

namespace Course12._2_DateTimeOps {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2020, 8, 15, 13, 45, 58);
            DateTime d2 = new DateTime(2020, 8, 18, 13, 45, 58);

            TimeSpan t = d2.Subtract(d1);

            DateTime d3 = d1.AddHours(2);
            DateTime d4 = d1.AddMinutes(3);
            DateTime d5 = d1.AddDays(7);

            Console.WriteLine("Original: " + d1);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine("\nTime difference d1 to d2: " + t);
        }
    }
}
