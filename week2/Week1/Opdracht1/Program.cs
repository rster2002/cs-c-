using System;

namespace Opdracht1 {
    class Program {

        const double vatFactor = 1.21;

        static void Main(string[] args) {
            Console.Write("Geef prijs: ");

            if (double.TryParse(Console.ReadLine(), out double price)) {
                string displayPrice = price.ToString("0.00");
                string displayVat = (price * vatFactor - price).ToString("0.00");
                string displayTotal = (price * vatFactor).ToString("0.00");

                Console.WriteLine($"Prijs: {displayPrice}, btw: {displayVat}, totaal: {displayTotal}");
            } else {
                Console.WriteLine("De gegeven prijs is niet een getal");
            }

            Console.ReadKey();
        }
    }
}
