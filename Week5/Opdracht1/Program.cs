using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            Random rnd = new Random();
            int[] numbers = new int[20];
            int sum = 0;
            double average = 0;

            for (int i = 1; i <= numbers.Length; i++) {
                int randomNumber = rnd.Next(200 + 1);

                numbers[i - 1] = randomNumber;
                sum += randomNumber;

                Console.WriteLine($"Element {i - 1} is {randomNumber}");
            }

            average = (double) sum / numbers.Length;
            Console.WriteLine($"\nHet gemiddelde is {average}\n");

            int index = 0;
            foreach (int number in numbers) {
                Console.WriteLine("Verschil gemiddelde en element {0} is {1}", index, Math.Abs(average - number));
                index++;
            }

            Console.ReadKey();
        }
    }
}
