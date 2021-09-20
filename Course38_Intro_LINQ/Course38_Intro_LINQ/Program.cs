using System;
using System.Linq;
using System.Collections.Generic;


namespace Course38_Intro_LINQ {
    class Program {
        static void Main(string[] args) {

            // Specify the data source/Especificar a fonte de dados

            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression/Definir a expressão de consulta

            // var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            

            // Execute the query/Executar a consulta

            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
