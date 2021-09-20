using System;
using Course25_HerançaMultipla.Devices;

namespace Course25_HerançaMultipla {
    class Program {
        static void Main(string[] args) {

            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter\n");

            Scanner s = new Scanner() { SerialNumber = 1080 };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan() + "\n");

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
