using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quick.Input;

namespace Oefententamen_Periode_2 {
    class Program {
        Input input = new Input();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            string centence = input.readString("Geef een zin: ");

            string shuffledCentence = suffleWordsInCentence(centence);

            Console.WriteLine(shuffledCentence);
            Console.ReadKey();
        }

        string suffleWordsInCentence(string centence) {
            string newCentence = "";
            string[] words = centence.Split(' ');

            foreach (string word in words) {
                newCentence += shuffleWord(word) + " ";
            }

            return newCentence;
        }

        string shuffleWord(string word) {
            if (word.Length <= 3) return word;

            string firstCharacter = word.Substring(0, 1);
            string lastCharacter = word.Substring(word.Length - 1, 1);

            word = word.Remove(0, 1);
            word = word.Remove(word.Length - 1, 1);

            string middleCharacters = "";

            Random random = new Random();
            while (word.Length > 0) {
                int randomIndex = random.Next(0, word.Length);
                char randomChar = word[randomIndex];

                middleCharacters += randomChar;

                word = word.Remove(randomIndex, 1);
            }

            return firstCharacter + middleCharacters + lastCharacter;
        }
    }
}