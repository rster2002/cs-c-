using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef nummer 1: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Geef nummer 2: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Geef nummer 3: ");
            int number3 = int.Parse(Console.ReadLine());

            if (number1 > number3 && number2 > number3) {
                Console.WriteLine("Het derde getal is de kleinste van de drie");
            } else {
                Console.WriteLine("Het derde getal is niet de kleinste van de drie");
            }

            Console.ReadKey();
        }
    }
}
