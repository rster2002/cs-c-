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

        private bool hasNOfSpecificNumber(int number, int amountToCheck) {
            int countOfNumber = countAccurences(number);

            return countOfNumber == amountToCheck;
        }

        private bool hasNofNumber(int amountRequired) {
            for (int i = 1; i <= 6; i++) {
                bool hasRequiredNumber = hasNOfSpecificNumber(i, amountRequired);

                if (hasRequiredNumber) {
                    return true;
                }
            }

            return false;
        }

        public bool threeOfAKind() {
            return hasNofNumber(3) && !fourOfAKind() && !yahtzee() && !fullHouse();
        }

        public bool fourOfAKind() {
            return hasNofNumber(4) && !yahtzee();
        }

        public bool yahtzee() {
            for (int i = 1; i <= dice.Length - 1; i++) {
                bool isStillValid = dice[0].value == dice[i].value;

                if (!isStillValid) {
                    return false;
                }
            }

            return true;
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
