using System;

namespace Opdracht5 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef een getal: ");
            double number = int.Parse(Console.ReadLine());

            Console.Write("Geef een veelvoud om te controlleren: ");
            double multiple = int.Parse(Console.ReadLine());

            double result = number / multiple;

            if (result % 1 == 0) {
                Console.WriteLine($"{multiple} is een veelvoud van {number}");
            } else {
                Console.WriteLine($"{multiple} is geen een veelvoud van {number}");
            }

            Console.ReadKey();
        }
    }
}
