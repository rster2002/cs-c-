using System;

namespace Opdracht2 {
    class Program {
        static bool checkPrime(int number) {
            bool isPrime = true;

            int i = 2;
            while (isPrime && i < number) {
                if (number % i == 0) {
                    isPrime = false;
                }

                i++;
            }

            return isPrime;
        }

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

        static void Main(string[] args) {
            int input;

            do {
                Console.Write("Geef een getal: ");
                input = getAndValidateInput();

                if (input != 0) {
                    Console.WriteLine("{0} is{1}een priem getal.", input, checkPrime(input) ? " " : " niet ");
                }
            } while (input != 0);
        }
    }
}
