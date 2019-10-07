using System;

namespace Opdracht4 {
    class Program {
        static void Main(string[] args) {
            int lastNumber = 1;
            int secondToLastNumber = 1;

            Console.WriteLine(secondToLastNumber);
            Console.WriteLine(lastNumber);

            for (int i = 1; i <= 20 - 2; i++) {
                int newNumber = secondToLastNumber + lastNumber;

                secondToLastNumber = lastNumber;
                lastNumber = newNumber;

                Console.WriteLine(newNumber);
            }

            Console.ReadKey();
        }
    }
}
