using System;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef een getal van 1 t/m 4: ");
            int cardTypeNumber = int.Parse(Console.ReadLine());

            if (cardTypeNumber >= 1 && cardTypeNumber <= 4) {
                switch (cardTypeNumber) {
                    case 1:
                        Console.WriteLine("Klaveren");
                        break;

                    case 2:
                        Console.WriteLine("Ruiten");
                        break;

                    case 3:
                        Console.WriteLine("Harten");
                        break;

                    case 4:
                        Console.WriteLine("Schoppen");
                        break;
                }

                Console.ReadKey();
            } else {
                Console.WriteLine("Het moet een getal van 1 t/m 4 zijn");
                Main(args);
            }
        }
    }
}
