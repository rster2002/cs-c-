using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4 {
    class Program {
        static void Main(string[] args) {
            int searchNumber;
            int[] numbers = new int[20];

            int inputNumber = 1;
            int iteration = 0;
            while (inputNumber != 0 && iteration < 20) {
                Console.Write("Geef een getal (0=stoppen): ");
                inputNumber = int.Parse(Console.ReadLine());
                numbers[iteration] = inputNumber;

                iteration++;
            }

            Console.WriteLine("");
            Console.Write("Geef een zoek getal: ");
            searchNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"De zoekwaarde is {searchNumber}");

            int lastSeachNumber = 1;
            int accurences = 0;
            iteration = 0;
            while (lastSeachNumber != 0 && iteration < 20) {
                int number = numbers[iteration];

                if (number == searchNumber) accurences++;
                iteration++;
            }

            Console.WriteLine($"De zoekwaarde komt {accurences}x voor");
            Console.ReadKey();
        }
    }
}
