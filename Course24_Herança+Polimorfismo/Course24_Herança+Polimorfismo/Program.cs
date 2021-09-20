using System;
using Course24_Herança_Polimorfismo.Model.Entities;
using Course24_Herança_Polimorfismo.Model.Enums;

namespace Course24_Herança_Polimorfismo {
    class Program {
        static void Main(string[] args) {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Widht = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
