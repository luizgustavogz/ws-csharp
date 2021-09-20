using Exc6_AbstractMethods.Entities.Enums;

namespace Exc6_AbstractMethods.Entities {
    abstract class Shape {

        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
        }
    }
