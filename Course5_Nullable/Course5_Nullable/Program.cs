using System;

namespace Course5_Nullable {
    class Program {
        static void Main(string[] args) {

            /* Recurso para que dados de tipo valor (structs) possam receber o valor null
               Nullable<double> x = null;
               De um jeito mais simplificado -> double? x = null; */

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X is null");
            }

            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine("\nOperador de coalescência nula:"); 

            double a = x ?? 5; // a recebe o valor de x, mas se for nulo, recebe 5
            double b = y ?? 5; // b recebe o valor de y, mas se for nulo, recebe 5

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}