using Course24_Herança_Polimorfismo.Model.Enums;

namespace Course24_Herança_Polimorfismo.Model.Entities {
    abstract class AbstractShape : IShape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
