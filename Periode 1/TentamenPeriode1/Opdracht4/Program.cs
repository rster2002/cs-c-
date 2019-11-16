using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4 {
    class Program {
        static int intergerDeling(int number1, int number2, out int remainder) {
            int result = 0;

            while (number1 >= number2) {
                number1 -= number2;
                result++;
            }

            remainder = number1;
            return result;
        }

        static void Main(string[] args) {
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++) {
                int number1 = rnd.Next(1, 51);
                int number2 = rnd.Next(1, 6);

                int result = intergerDeling(number1, number2, out int remaider);

                Console.WriteLine($"{number1} / {number2} = {result} ({remaider})");
            }

            Console.WriteLine();
            Console.WriteLine("Einde programma");
            Console.ReadKey();
        }
    }
}
