using System;

namespace Opdracht3 {
    class Program {

        static int getAndValidate() {
            if (int.TryParse(Console.ReadLine(), out int number)) {
                return number;
            } else {
                Console.WriteLine("Not a number");
                return getAndValidate();
            }
        }

        static void Main(string[] args) {
            int inputNumber = 0;
            int numberTotal = 0;
            int iteration = 1;

            Console.WriteLine("Geef getallen: ");
            do {
                inputNumber = getAndValidate();

                if (inputNumber != 0 && iteration % 5 == 0) {
                    numberTotal += inputNumber;
                }

                iteration++;
            } while (inputNumber != 0);

            Console.WriteLine($"De som van de getallen is {numberTotal}");
            Console.ReadKey();
        }
    }
}
