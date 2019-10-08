using System;
using System.Linq;

namespace Opdracht4 {
    class Program {
        static void countAccurences(string input, out int countPoints, out int countCommas, out int countSemiColons) {
            countPoints = input.Count(c => c == '.');
            countCommas = input.Count(c => c == ',');
            countSemiColons = input.Count(c => c == ';');
        }

        static void Main(string[] args) {
            Console.Write("Geef een string op: ");
            string input = Console.ReadLine();

            countAccurences(input, out int countPoints, out int countCommas, out int countSemiColons);

            Console.WriteLine($"Er zijn {countPoints} punten, {countCommas} komma's en {countSemiColons} punt-komma's gevonden in '{input}'");
            Console.ReadKey();
        }
    }
}
