using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1 {
    class Program {

        const float vatFactor = 0.21f;

        static float calculateVat(float price) {
            return price * vatFactor;
        }

        static float getAndValidateInput() {
            bool isValidInput = false;

            do {
                isValidInput = float.TryParse(Console.ReadLine(), out float value);

                if (isValidInput) {
                    return value;
                } else {
                    Console.WriteLine("Dit is geen float.");
                }
            } while (!isValidInput);

            return 0f;
        }

        static string toEuroFormat(float price) {
            return "€ " + price.ToString("0.00");
        }

        static void Main(string[] args) {
            Console.Write("Geef een prijs: ");
            float price = getAndValidateInput();

            float vat = calculateVat(price);
            float total = price + vat;

            Console.WriteLine("Het totale bedrag is {0} (21% BTW = {1})", toEuroFormat(price), toEuroFormat(vat));
            Console.ReadKey();
        }
    }
}
