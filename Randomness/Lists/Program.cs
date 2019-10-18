using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists {
    class Program {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();

            int input = 0;
            bool shouldContinue;
            do {
                Console.Write("Geef een getal: ");
                input = int.Parse(Console.ReadLine());

                shouldContinue = input != 0;

                if (shouldContinue) {
                    numbers.Add(input);
                }
            } while (shouldContinue);

            foreach (int i in numbers) {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
