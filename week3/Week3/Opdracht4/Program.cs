using System;
using System.Linq;

namespace Opdracht4 {
    class Program {
        static void Main(string[] args) {
            double getInput(int inputNr) {
                Console.Write($"Geef nummer {inputNr}: ");
                if (double.TryParse(Console.ReadLine(), out double outputValue)) {
                    return outputValue;
                } else {
                    Console.WriteLine("Dit is geen decimaal getal");
                    return getInput(inputNr);
                }
            }

            double[] numbers = { getInput(1), getInput(2), getInput(3) };

            Console.WriteLine("De som van de getallen is: {0}", numbers.Sum());
            Console.WriteLine("Het demiddelde van de getallen is: {0}", numbers.Sum() / 3);
            Console.WriteLine("Het grootste getal is: {0}", numbers.Max());
            Console.WriteLine("Het kleinste getal is: {0}", numbers.Min());

            Console.ReadLine();
        }
    }
}
