using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            string[] words = new string[20];

            string inputWord;
            int currentIndex = 0;
            do {
                Console.Write("Geef een woord: ");
                inputWord = Console.ReadLine();

                words[currentIndex] = inputWord;

                currentIndex++;
            } while (inputWord.Length == 0 || currentIndex == 20);

            foreach (string word in words) {
                if (word.Length % 2 == 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                } else {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine(word);
            }

            Console.ResetColor();

            Console.WriteLine("\nEinde programma");
            Console.ReadKey();
        }
    }
}
