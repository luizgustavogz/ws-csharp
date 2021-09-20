using System;

namespace ApsPLP {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            int[] sum = new int[8], med = new int[4];
            string[] linguagem = { "Java", "C++", "Python", "Fortran" };

            for (i = 0; i <= 3; i++) {
                Console.WriteLine("Linguagem: " + linguagem[i]);
                Console.Write("Simplicidade: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Ortogonalidade: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Tipagem de dados: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Projeto de sintaxe: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Suporte para abstração: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Expressividade: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Verificação de tipos: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Tratamento de exceções: ");
                sum[i] += int.Parse(Console.ReadLine());
                Console.Write("Apelidos restritos: ");
                sum[i] += int.Parse(Console.ReadLine());
                med[i] = sum[i] / 9;
                Console.WriteLine("\nMédia da linguagem " + linguagem[i] + " = " + med[i] + "\n");
            }
        }
    }
}
