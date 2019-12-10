using System;
using System.Collections.Generic;
using System.IO;
using Quick.IO;

namespace Opdracht2 {
    class Program {
        Random random = new Random();
        const string wordFilePath = "./words.txt";

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Main(args); // For testing
        }

        void start() {
            List<string> words = wordList();
            string selectedWord = selectWordRandomly(words);

            HangmanGame game = new HangmanGame(selectedWord);

            bool hasWon = game.playGame();

            if (hasWon) {
                Console.WriteLine("Gefeliciteerd! Je heb gewonnen! Het woord was inderdaad: {0}", selectedWord);
            } else {
                Console.WriteLine("Helaas, het woord was: {0}", selectedWord);
            }

            Console.ReadKey();
        }

        List<string> wordList() {
            List<string> words = new List<string>();

            if (File.Exists(wordFilePath)) {
                StreamReader streamReader = new StreamReader(wordFilePath);

                while (!streamReader.EndOfStream) {
                    string word = streamReader.ReadLine();

                    words.Add(word);
                }

                streamReader.Close();
            } else {
                // Default list when the file containing words does not exist

                words.Add("Alamine");
                words.Add("Arginine");
                words.Add("Asparagine");
                words.Add("Asparaginezuur");
                words.Add("Cysteine");
                words.Add("Glutamine");
                words.Add("Glutaminezuur");
                words.Add("Glycine");
                words.Add("Histidine");
                words.Add("Isoleucine");
                words.Add("Leucine");
                words.Add("Lysine");
                words.Add("Methionine");
                words.Add("Fenylalanine");
                words.Add("Proline");
                words.Add("Serine");
                words.Add("Threonine");
                words.Add("Tryptofaan");
                words.Add("Tyrosine");
                words.Add("Valine");
            }

            return words;
        }

        string selectWordRandomly(List<string> words) {
            int randomIndex = random.Next(0, words.Count);
            string selectedWord = words[randomIndex];

            if (selectedWord.Length >= 3) {
                return selectedWord;
            } else {
                return selectWordRandomly(words);
            }
        }
    }
}
