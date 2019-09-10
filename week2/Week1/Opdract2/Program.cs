using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdract2 {
    class Program {

        static double AskNumber(int number) {
            Console.Write($"Geef getal {number.ToString()}: ");
            if (double.TryParse(Console.ReadLine(), out double value)) {
                return value;
            } else {
                Console.WriteLine("Dat is geen getal, probeer het opniew.");

                return AskNumber(number);
            }
        }

        static void Main(string[] args) {
            double[] numbers = { AskNumber(1), AskNumber(2), AskNumber(3) };
            double average = numbers.Sum() / numbers.Length;

            Console.WriteLine($"Het gemiddelde is {average.ToString("0.######")}");

            Console.ReadKey();
        }
    }
}
