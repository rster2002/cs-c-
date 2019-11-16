using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[] numbers = new int[20];
            int lowestNumber = 150;
            int lowestNumberCount = 0;

            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = rnd.Next(1, 150 + 1);
            }

            foreach (int number in numbers) {
                Console.WriteLine(number);
                if (number < lowestNumber) {
                    lowestNumber = number;
                }
            }

            foreach (int number in numbers) {
                if (number == lowestNumber) {
                    lowestNumberCount++;
                }
            }

            Console.WriteLine($"Het laagste getal is {lowestNumber}. Dit getal komt {lowestNumberCount}x voor.");
            Console.ReadKey();
        }
    }
}
