using System;
using Course15_Herança.Entities;

namespace Course15_Herança_Casting {
    class Program {
        static void Main(string[] args) {

            Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 0, 0.01);

            // DOWNCASTING

            BusinessAccount bacc1 = (BusinessAccount)acc2;
            bacc1.Loan(100.0);

            // Errado: BusinessAccount bacc2 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount) {
                // BusinessAccount bacc2 = (BusinessAccount)acc3;
                BusinessAccount bacc2 = acc3 as BusinessAccount;
                bacc2.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount) {
                // SavingsAccount bacc2 = (SavingsAccount)acc3;
                SavingsAccount bacc2 = acc3 as SavingsAccount;
                bacc2.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
