using System;
using System.Linq;

namespace Opdracht3 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Console.ReadKey();

            Main(args); // Only for testing
        }

        void start() {
            YahtzeeGame YahtzeeGame = new YahtzeeGame();
            YahtzeeGame.init();

            //playYahtzeeGame(YahtzeeGame);
            playYahtzeeGameAdvanced(YahtzeeGame);
        }

        void playYahtzeeGame(YahtzeeGame game) {
            int iterations = 0;

            do {
                game.roll();
                game.showResults();

                iterations++;
            } while (!game.yahtzee());

            Console.WriteLine($"Er waren {iterations} pogingen nodig voor yahtzee");
        }

        void playYahtzeeGameAdvanced(YahtzeeGame game) {
            int iterations = 0;
            int threeOfAKindCount = 0;
            int fourOfAKindCount = 0;
            int fullHousesCount = 0;
            int smallStraightCount = 0;
            int fullStraightCount = 0;

            int pointsScoredByThreeOfAKind = 0;
            int pointsScoredByFourOfAKind = 0;
            int pointsScoredByFullHouses = 0;
            int pointsScoredBySmallStraights = 0;
            int pointsScoredByFullStraights = 0;

            do {
                game.roll();

                Console.ForegroundColor = ConsoleColor.DarkGray;

                if (game.threeOfAKind()) {
                    threeOfAKindCount++;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    pointsScoredByThreeOfAKind += game.diceValues.Sum();
                }

                if (game.fourOfAKind()) {
                    fourOfAKindCount++;
                    Console.ForegroundColor = ConsoleColor.Green;

                    pointsScoredByFourOfAKind += game.diceValues.Sum();
                }

                if (game.fullHouse()) {
                    fullHousesCount++;
                    Console.ForegroundColor = ConsoleColor.Blue;

                    pointsScoredByFullHouses += 25;
                }

                if (game.smallStraight()) {
                    smallStraightCount++;
                    Console.ForegroundColor = ConsoleColor.Red;

                    pointsScoredBySmallStraights += 30;
                }

                if (game.fullStraight()) {
                    fullStraightCount++;
                    Console.ForegroundColor = ConsoleColor.Magenta;

                    pointsScoredByFullStraights += 40;
                }

                game.showResults();
                iterations++;
            } while (!game.yahtzee());

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Three of a kind: {threeOfAKindCount} ({pointsScoredByThreeOfAKind} punten)");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Four of a kind: {fourOfAKindCount} ({pointsScoredByFourOfAKind} punten)");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Full houses: {fullHousesCount} ({pointsScoredByFullHouses} punten)");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Small Straights: {smallStraightCount} ({pointsScoredBySmallStraights} punten)");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Full Straights: {fullStraightCount} ({pointsScoredByFullStraights} punten)");

            int totalPoints = pointsScoredByThreeOfAKind + pointsScoredByFourOfAKind + pointsScoredByFullHouses + pointsScoredBySmallStraights + pointsScoredByFullStraights + 50;

            Console.ResetColor();
            Console.WriteLine($"Je heb in totaal {totalPoints} punten gescoord.");
            Console.WriteLine($"Er waren {iterations} pogingen nodig voor yahtzee");
        }
    }
}
