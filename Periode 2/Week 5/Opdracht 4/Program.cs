using Quick.FS;
using Quick.Input;
using System;
using System.Collections.Generic;

namespace Opdracht_4 {
    class Program {
        Random random = new Random();
        Input input = new Input();
        FileRef wordsFile = new FileRef("./compiledWords.txt");

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Main(args); // For testing
        }

        void start() {
            List<string> wordList = readWords();
            string secretWord = randomWord(wordList: wordList);

            LingoGame game = new LingoGame();
            game.setSecretWord(word: secretWord);

            playLingo(game: game);

            Console.ReadKey();
        }

        List<string> readWords() => wordsFile.readToList();

        string randomWord(List<string> wordList) {
            int randomIndex = random.Next(0, wordList.Count);
            return wordList[randomIndex];
        }

        void playLingo(LingoGame game) {
            int attempts = 0;
            bool hasWon = false;

            while (attempts < 5 && !hasWon) {
                attempts++;

                string guessWord = input.readString(
                    $"Geef een 5 letter woord (poging {attempts}): ",
                    "Het moet een woord zijn bestaande uit 5 letters",
                    input => input.Length == 5
                );

                PositionState[] characterStates = game.evaluateGuess(guessWord);
                showGuessResults(characterStates: characterStates, guessWord: guessWord);

                if (game.isCorrectWord(guessWord: guessWord)) {
                    hasWon = true;
                }

                Console.WriteLine();
            }

            if (hasWon) {
                Console.WriteLine($"Gefeliciteerd! Het woord was inderdaad {game.secretWord}");
            } else {
                Console.WriteLine($"Helaas. Het woord was {game.secretWord}");
            }
        }

        void showGuessResults(PositionState[] characterStates, string guessWord) {
            for (int i = 0; i < characterStates.Length; i++) {
                PositionState positionState = characterStates[i];

                if (positionState == PositionState.Correct) {
                    Console.BackgroundColor = ConsoleColor.Red;
                } else if (positionState == PositionState.Contains) {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }

                Console.Write(guessWord[i]);
                Console.ResetColor();
            }
        }
    }
}
