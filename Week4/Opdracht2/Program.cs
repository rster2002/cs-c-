using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2 {
    class Program {
        static void Main(string[] args) {
            int numbersValidated = 0;
            int inputNumber = 0;

            Console.Write("Geef een richtgetal: ");
            int guideNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Geef getallen en eindig met '0'");

            do {
                Console.Write("> ");
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == guideNumber) {
                    numbersValidated++;
                }
            } while (inputNumber != 0);

            Console.WriteLine($"Er komen {numbersValidated} nummers overeen met het richtgetal ({guideNumber})");
            Console.ReadKey();
        }
    }
}
