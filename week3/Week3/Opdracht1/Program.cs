using System;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef getal 1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Geef getal 2: ");
            double number2 = double.Parse(Console.ReadLine());

            if (number1 > number2) {
                Console.WriteLine("De grootste waarde is {0}", number1.ToString());
                Console.WriteLine("De kleinste waarde is {0}", number2.ToString());
            } else if (number2 > number1) {
                Console.WriteLine("De grootste waarde is {0}", number2.ToString());
                Console.WriteLine("De kleinste waarde is {0}", number1.ToString());
            } else {
                Console.WriteLine("Beide getallen zijn even groot");
            }

            Console.ReadKey();
        }
    }
}
