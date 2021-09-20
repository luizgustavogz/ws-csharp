using System;
using System.Globalization;

namespace Course_Annotations {
    class Program {
        static void Main(string[] args) {
            /* Expressão Condicional Ternária
            Estrutura opcional ao if-else quando se deseja decidir um VALOR com base em uma condição
            Sintaxe:   ( condição ) ? valor_se_verdadeiro : valor_se_falso */

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;
            Console.WriteLine(discount);
        }
    }
}
