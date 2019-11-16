using System;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            const int arrayLength = 20;
            const int minRandomValue = 1;
            Random rnd = new Random();
            const int maxRandomValue = 99;

            int[] numbers = new int[arrayLength];

            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(minRandomValue, maxRandomValue + 1);
            }

            Console.WriteLine($"Minimum value: {minRandomValue}");
            Console.WriteLine($"Maximum value: {maxRandomValue}");

            foreach (int number in numbers) {
                if (number >= minRandomValue + 20 && number <= maxRandomValue - 20) {
                    Console.ForegroundColor = ConsoleColor.Green;
                } else if (number >= minRandomValue + 10 && number <= maxRandomValue - 10) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write($"{number} ");
            }

            Console.Write("\n");
            Console.ReadKey();
        }
    }
}
