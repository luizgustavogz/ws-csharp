using System;

namespace Course7_Params {
    class Program {
        static void Main(string[] args) {

            // Permite que calcule valor de n números
            Console.WriteLine("Usando params:");
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            // O parâmetro x da função se torna uma referência para a variável original (a)
            // A variável passada como parâmetro ref DEVE ser iniciada, uma forma de obrigar o usuário a iniciar a variável
            Console.WriteLine("\nUsando ref");
            int a = 10;
            Calculator.TripleRef(ref a);
            Console.WriteLine(a);

            // Uma variável de entrada e uma de saída. Out se torna uma referência para a variável de saída
            // A variável passada como parâmetro out não precisa ser iniciada
            Console.WriteLine("\nUsando out");
            int b = 5;
            int triple;
            Calculator.TripleOut(b, out triple);
            Console.WriteLine(triple);
        }
    }
}