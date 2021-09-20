using System;
using Course14_Enums.Entities.Enums;
using Course14_Enums.Entities;

namespace Course14_Enums {
    class Program {
        static void Main(string[] args) {

            Order order = new Order { 
                Id = 1080, 
                Moment = DateTime.Now, 
                Status = OrderStatus.PendingPayment 
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
