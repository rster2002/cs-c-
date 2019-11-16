using System;

namespace Opdracht3 {
    class Program {
        static int getAndValidateInput() {
            bool isValidInput = false;

            do {
                isValidInput = int.TryParse(Console.ReadLine(), out int value);

                if (isValidInput) {
                    return value;
                } else {
                    Console.WriteLine("Dit is geen int.");
                    Console.Write("Geef een ander getal: ");
                }
            } while (!isValidInput);

            return 0;
        }

        static bool isLeapYear(int year) => DateTime.IsLeapYear(year);

        static void Main(string[] args) {
            int input;

            do {
                Console.Write("Geef een jaar: ");
                input = getAndValidateInput();

                if (input != 0) {
                    Console.WriteLine("{0} is{1}een schrikkeljaar.", input, isLeapYear(input) ? " " : " niet ");
                }
            } while (input != 0);
        }
    }
}
