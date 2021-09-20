using System;

namespace Course9_Matriz {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // Quantos elementos a matriz possui

            Console.WriteLine(mat.Rank); // A primeira dimensão da matriz (linha)

            Console.WriteLine(mat.GetLength(0));

            Console.WriteLine(mat.GetLength(1)); // A segunda dimensão (coluna)
        }
    }
}
