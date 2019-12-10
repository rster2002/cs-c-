using Quick.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht2 {
    class HangmanGame {
        public string secretWord;
        public string guessedWord;

        private Input input = new Input();

        public HangmanGame(string word) {
            secretWord = word.ToLower();

            foreach (char character in word) {
                guessedWord += ".";
            }
        }

        public bool playGame() {
            List<char> playedChars = new List<char>();
            int attemptsLeft = 8;

            while (true) {
                showWord();

                showLetters(playedChars);

                Console.WriteLine("Je heb nog {0} pogingen.", attemptsLeft);

                char currentGuessChar = readChar(playedChars);

                bool containsChar = guessLetter(currentGuessChar);

                if (!containsChar) {
                    attemptsLeft--;

                    if (attemptsLeft == 0) {
                        return false;
                    }
                } else if (wordGuessed()) {
                    return true;
                }
            }
        }

        private string addSpacesBetween(string word) {
            string newWord = "";

            for (int i = 0; i < word.Length; i++) {
                newWord += word[i];

                if (i != word.Length - 1) {
                    newWord += " ";
                }
            }

            return newWord;
        }

        private void showWord() {
            Console.WriteLine();
            Console.WriteLine(addSpacesBetween(guessedWord));
            Console.WriteLine();
        }

        private void showLetters(List<char> letters) {
            Console.WriteLine("Ingevoerde letters: {0}", String.Join(" ", letters));
        }

        private char readChar(List<char> playedChars) {
            char playChar = input.readChar(
                "Geef letter: ",
                "Deze letter heb je al gespeeld",
                input => !playedChars.Contains(input)
            );

            playedChars.Add(playChar);

            return playChar;
        }

        public bool guessLetter(char character) {
            bool containsLetter = secretWord.Contains(character);

            if (containsLetter) {
                string newGuessedWord = "";

                for (int i = 0; i < secretWord.Length; i++) {
                    char currentChar = secretWord[i];

                    if (character == currentChar) {
                        newGuessedWord += character;
                    } else {
                        newGuessedWord += guessedWord[i];
                    }
                }

                guessedWord = newGuessedWord;
            }

            return containsLetter;
        }

        public bool wordGuessed() => secretWord == guessedWord;
    }
}
