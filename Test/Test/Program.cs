using System;
using System.Globalization;

namespace Test {
    class Program {
        static void Main(string[] args) {

            char tipo;
            double totalDin = 0.0, totalCheq = 0.0, total = 0.0, prDin, prCheq;

            Console.WriteLine("Digite (s) a qualquer momento para sair");

            do {
                Console.WriteLine();
                Console.Write("Método de pagamento dinheiro ou cheque (d/c): ");
                tipo = char.Parse(Console.ReadLine());               

                if (tipo == 'd') {
                    Console.Write("Digite o preço do produto: R$");
                    prDin = double.Parse(Console.ReadLine());
                    totalDin += prDin;
                }
                else if (tipo == 'c') {
                    Console.Write("Digite o preço do produto: R$");
                    prCheq = double.Parse(Console.ReadLine());
                    totalCheq += prCheq;
                }
                total = totalDin + totalCheq;
            } while (tipo != 's');

            Console.WriteLine("Valor total de compras à vista em dinheiro: R$" + totalDin.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor total de compras à vista em cheque: R$" + totalCheq.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor total de compras efetuadas: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
