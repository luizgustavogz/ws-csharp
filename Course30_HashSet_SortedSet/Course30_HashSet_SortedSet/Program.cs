using System;
using System.Collections.Generic;

namespace Course30_HashSet_SortedSet {
    class Program {
        static void Main(string[] args) {

            HashSet<string> set = new HashSet<string>();

            Console.WriteLine("--HashSet--");
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            // Verifica se o item indicado pertence ao conjunto, caso não esteja, retornará falso
            Console.WriteLine("Contêm no conjunto = " + set.Contains("Notebook"));

            foreach (string p in set) {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n--SortedSet--");
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // Union: Acrescenta os elementos de um conjunto que não estão no conjunto inicial (elementos de B que não pertencem a A)
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            Console.Write("Union: ");
            PrintCollection(c);

            // Intersection: Apenas os elementos que estam presentes nos dois conjuntos comparados
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            Console.Write("Intersection: ");
            PrintCollection(d);

            // Exception: Apenas os elementos diferentes entre os dois conjuntos
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            Console.Write("Except: ");
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
