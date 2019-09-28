using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4 {
    class Program {
        static void Main(string[] args) {
            int lastNumber = 1;
            int secondToLastNumber = 1;

            Console.WriteLine(lastNumber);
            Console.WriteLine(secondToLastNumber);

            for (int i = 1; i <= 18; i++) {
                int newNumber = secondToLastNumber + lastNumber;

                secondToLastNumber = lastNumber;
                lastNumber = newNumber;

                Console.WriteLine(newNumber);
            }

            Console.ReadKey();
        }
    }
}
