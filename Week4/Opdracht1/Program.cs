using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            int numberCount = 0;
            int numberTotal = 0;

            int inputNumber = 0;

            do {
                Console.Write("Geef getal {0}: ", numberCount + 1);
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber != 0) {
                    numberCount++;
                    numberTotal += inputNumber;
                }
            } while (inputNumber != 0);

            double average = numberTotal / numberCount;

            Console.WriteLine("Het gemiddelde is {0}", average.ToString());
            Console.ReadKey();
        }
    }
}
