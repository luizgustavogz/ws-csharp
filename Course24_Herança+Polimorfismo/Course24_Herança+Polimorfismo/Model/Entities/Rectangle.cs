using System.Globalization;

namespace Course24_Herança_Polimorfismo.Model.Entities {
    class Rectangle : AbstractShape {

        public double Widht { get; set; }
        public double Height { get; set; }

        public override double Area() {
            return Widht * Height;
        }

        public override string ToString() {
            return "Rectangle color = " + Color + ", widht = " + Widht.ToString("F2", CultureInfo.InvariantCulture) 
                + ", height = " + Height.ToString("F2", CultureInfo.InvariantCulture) + ", area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
