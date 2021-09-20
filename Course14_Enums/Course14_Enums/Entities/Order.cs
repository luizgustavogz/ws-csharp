using System;
using Course14_Enums.Entities.Enums;

namespace Course14_Enums.Entities {
    class Order {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
