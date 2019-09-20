using System;

namespace Opdracht8 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Hoeveel uur is de metaaldraaibank al in gebruik (hele uren): ");
            int hoursUsed = int.Parse(Console.ReadLine());

            Console.Write("Hoe oud is de metaaldraaibank (in hele jaren): ");
            int yearsInUse = int.Parse(Console.ReadLine());

            Console.Write("Hoeveel storingen zijn er geweest dit jaar: ");
            int defectsThisYear = int.Parse(Console.ReadLine());

            if (hoursUsed > 10000 || yearsInUse > 7 || defectsThisYear > 25) {
                Console.WriteLine("De metaaldraaibank moet worden vervangen");
            } else {
                Console.WriteLine("De metaaldraaibank hoeft nog niet te worden vervangen");
            }

            Console.ReadKey();
        }
    }
}
