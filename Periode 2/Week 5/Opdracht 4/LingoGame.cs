using System.Collections.Generic;

namespace Opdracht_4 {
    class LingoGame {
        public string secretWord = "";

        public void setSecretWord(string word) {
            secretWord = word;
        }

        public PositionState[] evaluateGuess(string guessWord) {
            PositionState[] characterPositions = new PositionState[5];
            List<char> charactersInWord = new List<char>();

            for (int i = 0; i < secretWord.Length; i++) {
                char secretWordChar = secretWord[i];
                char guessWordChar = guessWord[i];

                if (secretWordChar != guessWordChar) {
                    charactersInWord.Add(secretWordChar);
                }
            }

            for (int i = 0; i < secretWord.Length; i++) {
                char secretWordChar = secretWord[i];
                char guessWordChar = guessWord[i];

                if (secretWordChar == guessWordChar) {
                    characterPositions[i] = PositionState.Correct;
                } else if (charactersInWord.Contains(guessWordChar)) {
                    characterPositions[i] = PositionState.Contains;
                    charactersInWord.Remove(guessWordChar);
                } else {
                    characterPositions[i] = PositionState.Incorrect;
                }
            }

            return characterPositions;
        }

        public bool isCorrectWord(string guessWord) {
            return secretWord == guessWord;
        }
    }
}
