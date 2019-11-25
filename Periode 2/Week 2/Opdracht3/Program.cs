using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3 {
    class Program {
        Random random = new Random();

        enum RegularCandy {
            JellyBean = 1,
            Lozenge,
            LemonDrop,
            GumSquare,
            LollipopHead,
            JujubeCluster
        }

        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            //Main(args); // For testing
        }

        void start() {
            RegularCandy[,] candyGrid = new RegularCandy[9, 9];

            initCandies(candyGrid);
            printCandies(candyGrid);

            bool scoreRowPresent = checkScoreRowPresent(candyGrid);
            bool scoreColumnPresent = checkScoreColumnPresent(candyGrid);

            Console.WriteLine("{0}, er is {1}een score rij aanwezig", scoreRowPresent ? "Ja" : "Nee", scoreRowPresent ? "" : "GEEN ");
            Console.WriteLine("{0}, er is {1}een score kolom aanwezig", scoreColumnPresent ? "Ja" : "Nee", scoreColumnPresent ? "" : "GEEN ");

            Console.ReadKey();
        }

        void initCandies(RegularCandy[,] grid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    int candyCountPossible = Enum.GetNames(typeof(RegularCandy)).Length;

                    grid[r, c] = (RegularCandy) random.Next(1, candyCountPossible + 1);
                }
            }
        }

        ConsoleColor getColorForCandy(RegularCandy candy) {
            int candyIndex = (int) candy;

            switch (candyIndex) {
                case 1:
                    return ConsoleColor.Red;

                case 2:
                    return ConsoleColor.Cyan;

                case 3:
                    return ConsoleColor.Yellow;

                case 4:
                    return ConsoleColor.Green;

                case 5:
                    return ConsoleColor.Blue;

                case 6:
                    return ConsoleColor.Magenta;

                default:
                    return ConsoleColor.White;
            }
        }

        void printCandy(RegularCandy candy) {
            Console.ForegroundColor = getColorForCandy(candy);
            Console.Write("#");
            Console.ResetColor();
        }

        void printCandies(RegularCandy[,] grid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    printCandy(grid[r, c]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        bool checkScoreRowPresent(RegularCandy[,] grid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1) - 2; c++) {
                    RegularCandy comparisonCandy = grid[r, c];

                    if (grid[r, c + 1] == comparisonCandy && grid[r, c + 2] == comparisonCandy) {
                        return true;
                    }
                }
            }

            return false;
        }

        bool checkScoreColumnPresent(RegularCandy[,] grid) {
            for (int c = 0; c < grid.GetLength(0); c++) {
                for (int r = 0; r < grid.GetLength(1) - 2; r++) {
                    RegularCandy comparisonCandy = grid[r, c];

                    if (grid[r + 1, c] == comparisonCandy && grid[r + 1, c] == comparisonCandy) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
