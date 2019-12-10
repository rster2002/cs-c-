using Quick.Input;
using System;
using System.IO;

namespace Opdracht_3 {
    class Program {
        Input input = new Input();
        const string tweetFile = "./tweetsDonalTrump2018.txt";

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Main(args); // For testing
        }

        void start() {
            string searchWord = input.readString("Enter a word (to search): ");

            int wordOnLines = searchWordInFile(tweetFile, searchWord);

            Console.WriteLine();
            Console.WriteLine($"Number of lines containing the word: {wordOnLines}");

            Console.ReadKey();
        }

        bool wordInLine(string line, string word) => line.ToLower().Contains(word);

        int searchWordInFile(string fileName, string word) {
            StreamReader streamReader = new StreamReader(fileName);

            int accurances = 0;

            while (!streamReader.EndOfStream) {
                string line = streamReader.ReadLine();

                if (wordInLine(line, word)) {
                    showWordInLine(line, word);

                    accurances++;
                }
            }

            streamReader.Close();

            return accurances;
        }

        void showWordInLine(string line, string word) {
            int startIndex = line.ToLower().IndexOf(word);

            string foundWord = line.Substring(startIndex, word.Length);

            int endOfWordIndex = startIndex + foundWord.Length;

            string preSubstring = line.Substring(0, startIndex);
            string endSubstring = line.Substring(endOfWordIndex, line.Length - endOfWordIndex);

            Console.Write(preSubstring);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(foundWord);

            Console.ResetColor();

            if (wordInLine(endSubstring, word)) {
                showWordInLine(endSubstring, word);
            } else {
                Console.Write(endSubstring);
            }
        }
    }
}
