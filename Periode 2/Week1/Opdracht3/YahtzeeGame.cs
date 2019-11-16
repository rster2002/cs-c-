using System;

namespace Opdracht3 {
    class YahtzeeGame {
        Die[] dice = new Die[5];
        public int[] diceValues = new int[5];

        public void init() {
            for (int i = 0; i < dice.Length; i++) {
                dice[i] = new Die();
            }
        }
        
        public void roll() {
            for (int i = 0; i < dice.Length; i++) {
                Die die = dice[i];
                die.roll();

                diceValues[i] = die.value;
            }
        }

        public void showResults() {
            foreach (Die die in dice) {
                die.showValue();
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        private int countAccurences(int numberToCount) {
            Die[] countArray = Array.FindAll(dice, die => die.value == numberToCount);

            return countArray.Length;
        }

        private bool nWasRolled(int valueToCheck) {
            int accurences = countAccurences(valueToCheck);

            return accurences > 0;
        }

        private bool allDiceHaveValue(int valueToCheck, int amountToCheck) {
            int countOfNumber = countAccurences(valueToCheck);

            return countOfNumber == amountToCheck;
        }

        private bool hasNofNumber(int amountRequired) {
            bool fullOnes = allDiceHaveValue(1, amountRequired);
            bool fullTwos = allDiceHaveValue(2, amountRequired);
            bool fullThrees = allDiceHaveValue(3, amountRequired);
            bool fullFours = allDiceHaveValue(4, amountRequired);
            bool fullFives = allDiceHaveValue(5, amountRequired);
            bool fullSixes = allDiceHaveValue(6, amountRequired);

            return fullOnes || fullTwos || fullThrees || fullFours || fullFives || fullFives || fullSixes;
        }

        public bool threeOfAKind() {
            return hasNofNumber(3) && !fourOfAKind() && !yahtzee() && !fullHouse();
        }

        public bool fourOfAKind() {
            return hasNofNumber(4) && !yahtzee();
        }

        public bool yahtzee() {
            return hasNofNumber(5);
        }

        public bool fullHouse() {
            return hasNofNumber(2) && hasNofNumber(3);
        }

        public bool smallStraight() {
            bool firstPossibility = nWasRolled(1) && nWasRolled(2) && nWasRolled(3) && nWasRolled(4);
            bool secondPossibility = nWasRolled(2) && nWasRolled(3) && nWasRolled(4) && nWasRolled(5);
            bool thirdPossibility = nWasRolled(3) && nWasRolled(4) && nWasRolled(5) && nWasRolled(6);

            return (firstPossibility || secondPossibility || thirdPossibility) && !fullStraight();
        }

        public bool fullStraight() {
            bool firstPossibility = nWasRolled(1) && nWasRolled(2) && nWasRolled(3) && nWasRolled(4) && nWasRolled(5);
            bool secondPossibility = nWasRolled(2) && nWasRolled(3) && nWasRolled(4) && nWasRolled(5) && nWasRolled(6);

            return firstPossibility || secondPossibility;
        }
    }
}
