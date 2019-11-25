using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3complex {
    class Position {
        public int row = -1;
        public int column = -1;

        public Position(int initRow, int initColumn) {
            row = initRow;
            column = initColumn;
        }

        public Position clone() {
            return new Position(row, column);
        }
    }

    class Program {
        Random random = new Random();
        RegularCandy[,] grid = new RegularCandy[9, 9];
        Position cursor = new Position(0, 0);
        int score = 0;

        enum RegularCandy {
            Empty = 0,
            JellyBean,
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
            initCandies(grid);

            while (true) {
                Console.Clear();

                //Console.WriteLine("Applying Gravity");
                applyGravity();
                fillEmptySlots();

                //Console.WriteLine("Printing screen");
                printCandies();
                Console.WriteLine("Score: " + score);

                //Console.WriteLine("Awaiting User Input");
                userInput();

                //applyGravity();

                //Console.WriteLine("Applying scores");
                resolveScores();

                //Console.WriteLine(readKey.Key);
            }
        }

        void initCandies(RegularCandy[,] grid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    int candyCountPossible = Enum.GetNames(typeof(RegularCandy)).Length;

                    grid[r, c] = (RegularCandy) random.Next(1, candyCountPossible);
                }
            }
        }

        void fillEmptySlots() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    RegularCandy candyAtCurrentPosition = grid[r, c];

                    if (candyAtCurrentPosition == RegularCandy.Empty) {
                        int candyCountPossible = Enum.GetNames(typeof(RegularCandy)).Length;

                        grid[r, c] = (RegularCandy) random.Next(1, candyCountPossible);
                    }
                }
            }
        }

        ConsoleColor getColorForCandy(RegularCandy candy) {
            int candyIndex = (int) candy;

            switch (candyIndex) {
                case 0:
                    return ConsoleColor.Black;

                case 1:
                    return ConsoleColor.Red;

                case 2:
                    return ConsoleColor.DarkCyan;

                case 3:
                    return ConsoleColor.Yellow;

                case 4:
                    return ConsoleColor.DarkRed;

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

        void printCandies() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write(r == cursor.row && c == cursor.column ? "[" : " ");

                    printCandy(grid[r, c]);

                    Console.Write(r == cursor.row && c == cursor.column ? "]" : " ");
                }

                Console.WriteLine();
            }
        }

        void checkScoreFromPosition(int r, int c, string checkDirection) {
            RegularCandy currentCandy = grid[r, c];
            bool foundScoreRow = false;
            bool foundScoreColumn = false;

            if (currentCandy != RegularCandy.Empty) {
                if (checkDirection == "row" || checkDirection == "both") {
                    if (c < grid.GetLength(0) - 2 && currentCandy == grid[r, c + 1] && currentCandy == grid[r, c + 2]) {
                        score += 150;

                        checkScoreFromPosition(r, c + 1, "column");
                        checkScoreFromPosition(r, c + 2, "column");

                        grid[r, c + 1] = RegularCandy.Empty;
                        grid[r, c + 2] = RegularCandy.Empty;

                        foundScoreRow = true;
                    } else if (c > 0 && c < grid.GetLength(0) - 1 && currentCandy == grid[r, c - 1] && currentCandy == grid[r, c + 1]) {
                        score += 150;

                        checkScoreFromPosition(r, c + 1, "column");
                        checkScoreFromPosition(r, c - 1, "column");

                        grid[r, c + 1] = RegularCandy.Empty;
                        grid[r, c - 1] = RegularCandy.Empty;

                        foundScoreRow = true;
                    } else if (c > 2 && currentCandy == grid[r, c - 2] && currentCandy == grid[r, c - 1]) {
                        score += 150;

                        checkScoreFromPosition(r, c - 1, "column");
                        checkScoreFromPosition(r, c - 2, "column");

                        grid[r, c - 1] = RegularCandy.Empty;
                        grid[r, c - 2] = RegularCandy.Empty;

                        foundScoreRow = true;
                    }
                }

                if (checkDirection == "column" || checkDirection == "both") {
                    if (r < grid.GetLength(1) - 2 && currentCandy == grid[r + 1, c] && currentCandy == grid[r + 2, c]) {
                        score += 150;

                        checkScoreFromPosition(r + 1, c, "row");
                        checkScoreFromPosition(r + 2, c, "row");

                        grid[r + 1, c] = RegularCandy.Empty;
                        grid[r + 2, c] = RegularCandy.Empty;

                        foundScoreColumn = true;
                    } else if (r > 0 && r < grid.GetLength(1) - 1 && currentCandy == grid[r + 1, c] && currentCandy == grid[r - 1, c]) {
                        score += 150;

                        checkScoreFromPosition(r + 1, c, "row");
                        checkScoreFromPosition(r - 1, c, "row");

                        grid[r + 1, c] = RegularCandy.Empty;
                        grid[r - 1, c] = RegularCandy.Empty;

                        foundScoreColumn = true;
                    } else if (r > 2 && currentCandy == grid[r - 1, c] && currentCandy == grid[r - 2, c]) {
                        score += 150;

                        checkScoreFromPosition(r - 1, c, "row");
                        checkScoreFromPosition(r - 2, c, "row");

                        grid[r - 1, c] = RegularCandy.Empty;
                        grid[r - 2, c] = RegularCandy.Empty;

                        foundScoreColumn = true;
                    }
                }

                if (foundScoreRow || foundScoreColumn) {
                    grid[r, c] = RegularCandy.Empty;
                }
            }
        }

        void resolveScores() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    checkScoreFromPosition(r, c, "both");
                }
            }
        }

        void applyGravity() {
            for (int c = 0; c < grid.GetLength(1); c++) {
                for (int i = 0; i < grid.GetLength(0); i++) {
                    for (int r = 0; r < grid.GetLength(0); r++) {
                        RegularCandy currentCandy = grid[r, c];

                        if (currentCandy != RegularCandy.Empty) {
                            if (r + 1 < grid.GetLength(0)) {
                                RegularCandy candyBelow = grid[r + 1, c];

                                if (candyBelow == RegularCandy.Empty) {
                                    switchCandyPositions(new Position(r, c), new Position(r + 1, c));
                                }
                            }
                        }
                    }
                }
            }
        }

        void userInput() {
            var readKey = Console.ReadKey();

            switch (readKey.Key) {
                case ConsoleKey.W:
                    if (cursor.row > 0)
                        cursor.row--;
                break;

                case ConsoleKey.A:
                    if (cursor.column > 0)
                        cursor.column--;
                break;

                case ConsoleKey.S:
                    if (cursor.row < grid.GetLength(0) - 1)
                        cursor.row++;
                break;

                case ConsoleKey.D:
                    if (cursor.column < grid.GetLength(1) - 1)
                        cursor.column++;
                break;

                case ConsoleKey.Spacebar:
                    showMoveInput();
                break;
            }
        }

        void switchCandyPositions(Position pos1, Position pos2) {
            if (pos2.row > 0 && pos2.row < grid.GetLength(0) && pos2.column > 0 && pos2.column < grid.GetLength(1)) {
                RegularCandy candyAtPos1 = grid[pos1.row, pos1.column];
                RegularCandy candyAtPos2 = grid[pos2.row, pos2.column];

                grid[pos1.row, pos1.column] = candyAtPos2;
                grid[pos2.row, pos2.column] = candyAtPos1;

                return;
            } else {
                //showMoveInput();
            }
        }

        void showMoveInput() {
            while (true) {
                var readKey = Console.ReadKey();
                Position candyToMovePosition = new Position(cursor.row, cursor.column);

                switch (readKey.Key) {
                    case ConsoleKey.W:
                        candyToMovePosition.row--;
                        break;

                    case ConsoleKey.A:
                        candyToMovePosition.column--;
                        break;

                    case ConsoleKey.S:
                        candyToMovePosition.row++;
                        break;

                    case ConsoleKey.D:
                        candyToMovePosition.column++;
                        break;
                }

                switchCandyPositions(cursor, candyToMovePosition);

                return;
            }
        }
    }
}
