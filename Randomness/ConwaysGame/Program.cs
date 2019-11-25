using System;
using System.Timers;

namespace ConwaysGame {
    class Position {
        public int row = -1;
        public int column = -1;

        public Position(int r, int c) {
            row = r;
            column = c;
        }
    }

    class Program {
        bool[,] grid = new bool[30, 50];
        Position cursor = new Position(0, 0);
        bool showNaborDebug = false;

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            initGridSelect();

            startGame();

            start();
        }

        void startGame() {
            Console.Clear();
            printGrid();

            Console.WriteLine();
            Console.Write("Game tick speed (in TPS): ");
            int tickSpeed = int.Parse(Console.ReadLine());

            Timer timer = new System.Timers.Timer();
            timer.Interval = 1000 / tickSpeed;
            timer.Elapsed += gameTick;
            timer.AutoReset = true;
            timer.Enabled = true;

            Console.ReadKey();

            timer.Enabled = false;

            return;
        }

        void gameTick(Object source, System.Timers.ElapsedEventArgs e) {
            bool[,] nextGeneration = new bool[grid.GetLength(0), grid.GetLength(1)];

            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    int nabors = 0;
                    bool alive = grid[r, c];
                    bool nextGenerationValue;

                    if (c > 0 && grid[r, c - 1]) {
                        nabors++;
                    }

                    if (c < grid.GetLength(1) - 1 && grid[r, c + 1]) {
                        nabors++;
                    }

                    if (r > 0 && grid[r - 1, c]) {
                        nabors++;
                    }

                    if (r < grid.GetLength(0) - 1 && grid[r + 1, c]) {
                        nabors++;
                    }

                    if (r > 0 && c > 0 && grid[r - 1, c - 1]) {
                        nabors++;
                    }

                    if (r > 0 && c < grid.GetLength(1) - 1 && grid[r - 1, c + 1]) {
                        nabors++;
                    }

                    if (r < grid.GetLength(0) - 1 && c > 0 && grid[r + 1, c - 1]) {
                        nabors++;
                    }

                    if (r < grid.GetLength(0) - 1 && c < grid.GetLength(1) - 1 && grid[r + 1, c + 1]) {
                        nabors++;
                    }

                    if (alive) {
                        if (nabors == 2 || nabors == 3) {
                            nextGenerationValue = true;
                        } else {
                            nextGenerationValue = false;
                        }
                    } else {
                        if (nabors == 3) {
                            nextGenerationValue = true;
                        } else {
                            nextGenerationValue = false;
                        }
                    }

                    nextGeneration[r, c] = nextGenerationValue;

                    if (!showNaborDebug) {
                        if (alive != nextGenerationValue) {
                            Console.SetCursorPosition(c * 3 + 1, r);

                            if (nextGenerationValue) {
                                Console.Write("#");
                            } else {
                                Console.Write(" ");
                            }

                            Console.SetCursorPosition(0, grid.GetLength(0));
                        }
                    } else {
                        Console.SetCursorPosition(c * 3 + 1, r);

                        if (nabors > 0) {
                            Console.Write(nabors);
                        } else {
                            Console.Write(" ");
                        }

                        Console.SetCursorPosition(0, grid.GetLength(0));
                    }
                }

                if (showNaborDebug) {
                    Console.WriteLine();
                }
            }

            grid = nextGeneration;

            //printGrid();
            Console.WriteLine("Press any key at any time to stop");
        }

        void initGridSelect() {
            Console.Clear();
            printWithCursor();

            while (true) {

                printCursor();

                var keyPress = Console.ReadKey();

                removeOldCursorPosition();

                if (keyPress.Key == ConsoleKey.W && cursor.row > 0) {
                    cursor.row--;
                } else if (keyPress.Key == ConsoleKey.S && cursor.row < grid.GetLength(0) - 1) {
                    cursor.row++;
                } else if(keyPress.Key == ConsoleKey.A && cursor.column > 0) {
                    cursor.column--;
                } else if(keyPress.Key == ConsoleKey.D && cursor.column < grid.GetLength(1) - 1) {
                    cursor.column++;
                } else if (keyPress.Key == ConsoleKey.Spacebar) {
                    grid[cursor.row, cursor.column] = !grid[cursor.row, cursor.column];
                    Console.SetCursorPosition(cursor.column * 3 + 1, cursor.row);
                    Console.Write(grid[cursor.row, cursor.column] ? "#" : "-");
                    Console.SetCursorPosition(0, grid.GetLength(0));
                } else if (keyPress.Key == ConsoleKey.Enter) {
                    return;
                } else if (keyPress.Key == ConsoleKey.R) {
                    for (int r = 0; r < grid.GetLength(0); r++) {
                        for (int c = 0; c < grid.GetLength(1); c++) {
                            grid[r, c] = false;
                        }
                    }

                    Console.Clear();
                    printWithCursor();
                }
            }
        }

        void printCursor() {
            int leftPosition = cursor.column * 3;
            int topPosition = cursor.row;

            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write("[");
            Console.SetCursorPosition(leftPosition + 2, topPosition);
            Console.Write("]");
            Console.SetCursorPosition(0, grid.GetLength(0));
        }

        void removeOldCursorPosition() {
            int leftPosition = cursor.column * 3;
            int topPosition = cursor.row;

            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write(" ");
            Console.SetCursorPosition(leftPosition + 2, topPosition);
            Console.Write(" ");
            Console.SetCursorPosition(0, grid.GetLength(0));
        }

        void printWithCursor() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write(" ");
                    Console.Write(grid[r, c] ? "#" : "-");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            //Console.SetCursorPosition(0, 0);
            //Console.Write("T");
        }

        void printGrid() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write(" ");
                    Console.Write(grid[r, c] ? "#" : " ");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
