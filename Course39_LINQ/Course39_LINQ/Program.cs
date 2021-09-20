using System;
using Course39_LINQ.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course39_LINQ {
    class Program {

        static void Print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach (T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args) {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product(){ Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product(){ Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product(){ Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product(){ Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product(){ Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product(){ Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product(){ Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product(){ Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product(){ Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product(){ Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product(){ Id = 11, Name = "Level", Price = 70.0, Category = c1}
            };

            // Filtra apenas os produtos de Tier 1 e preço menor que 900
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            // Filtra os produtos que estão na categoria "Tools", selecionando apenas o nome
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", r2);

            // Filtra os produtos que começam com a letra 'C' como objeto anônimo, selecionando apenas o que quer imprimir, no caso: nome, preço e categoria
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            // Filtra os produtos de Tier 1 e os ordena por preço e depois por nome (caso o preço seja o mesmo)
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            // Pula 2 e pega 4 da lista filtrada por produtos de Tier 1 ordenados por preço e depois por nome
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            // Primeiro produto da lista, caso não exista retorna vazio (default)
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            // Primeiro produto da lista que possua o preço maior que 3000, caso não exista retorna vazio (default)
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);

            // Resultado específico (id = 3), caso não exista retorna vazio (default)
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("\nSingle or default test1: " + r8);
            // Resultado específico (id = 30), caso não exista retorna vazio (default)
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);

            // Filtrar o maior preço
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("\nMax price: " + r10);
            // Filtrar o menor preço
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);
            // Filtra os produtos da categoria 1 e faz a soma do preço
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);
            // Filtra os produtos da categoria 1 e faz a média do preço
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            // Caso a coleção selecionada esteja vazia, ao invés de lançar uma exceção, irá lançar o valor default definido
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            // Agrupa a coleção pelo critério escolhido e imprime os produtos agrupados nas categorias
            var r16 = products.GroupBy(p => p.Category);
            foreach (IGrouping<Category, Product> group in r16) {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach(Product p in group) {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
