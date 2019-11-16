using System;

namespace Opdracht2 {
    class Program {
        static int getInput() {
            Console.Write("Voer een getal in: ");
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args) {
            int number = getInput();
            int factor;

            while (number >= 1) {
                factor = 2;

                while (number != factor) {
                    if (number % factor == 0) {
                        number = number / factor;
                        Console.Write($"{factor} ");
                    } else {
                        factor++;
                    }
                }

                Console.Write(number);
                Console.WriteLine();

                number = getInput();
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadKey();
        }
    }
}
