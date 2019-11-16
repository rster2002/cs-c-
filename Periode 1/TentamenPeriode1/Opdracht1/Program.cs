using System;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            int totalRequiredECs = 60;
            double requiredECs;

            Console.Write("Geef je naam: ");
            string studentName = Console.ReadLine();

            Console.Write("Geef jouw aantal vrijstelling EC's: ");
            int subtractECs = int.Parse(Console.ReadLine());

            Console.Write("Geef jouw totaal aantal EC's van jaar 1: ");
            int totalEarnedECs = int.Parse(Console.ReadLine());

            totalRequiredECs -= subtractECs;
            requiredECs = (totalRequiredECs * 0.75) + subtractECs;

            Console.WriteLine($"(vereist aantal EC's om naar jaar 2 te mogen: {requiredECs})");
            Console.WriteLine();

            if (totalEarnedECs >= requiredECs) {
                Console.WriteLine($"{studentName}, je heb genoeg EC's om door te mogen naar jaar 2.");
            } else {
                Console.WriteLine($"{studentName}, je heb (nog) niet genoeg EC's om door te mogen naar jaar 2.");
            }

            Console.ReadKey();
        }
    }
}
