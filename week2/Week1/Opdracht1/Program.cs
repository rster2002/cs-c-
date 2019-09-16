using System;

namespace Opdracht1 {
    class Program {

        const double vatFactor = 1.21;

        static void Main(string[] args) {
            Console.Write("Geef prijs: ");

            if (double.TryParse(Console.ReadLine(), out double price)) {
                double priceInclVat = price * vatFactor;
                double vat = priceInclVat - price;

                Console.WriteLine("Prijs: {0}, btw: {1}, totaal: {2}", price.ToString("0.00"), vat.ToString("0.00"), priceInclVat.ToString("0.00"));
            } else {
                Console.WriteLine("De gegeven prijs is niet een getal");
            }

            Console.ReadKey();
        }
    }
}
