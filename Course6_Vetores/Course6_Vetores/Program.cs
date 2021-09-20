using System;
using System.Globalization;

namespace Course6_Vetores {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            double[] alt = new double[n];

            for (int i = 0; i < n; i++) {
                alt[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) {
                sum += alt[i];
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
