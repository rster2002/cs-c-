using System;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Geef een woord: ");
            string word = Console.ReadLine();

            string invertedWord = "";
            foreach (char c in word) {
                invertedWord = c + invertedWord;
            }

            bool isPalindrome = word == invertedWord;

            Console.WriteLine("{0}is {1} palindroom ({2})", word, isPalindrome ? "een" : "geen", invertedWord);
            Console.ReadKey();
        }
    }
}
