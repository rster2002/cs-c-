using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame {
    class ConwaysGame {
        bool[,] grid;
        bool[,] lastDraw;
        bool didInitialDraw = false;
        Position cursor = new Position(0, 0);

        public ConwaysGame(int rows, int columns) {
            grid = new bool[rows, columns];
            lastDraw = new bool[rows, columns];
        }

        public void getInput() {
            initGridSelect();
        }

        public void initialDraw() {
            didInitialDraw = true;
            printGrid();
        }

        private void printGrid() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write("   ");
                }

                Console.WriteLine();
            }

            reDraw();
        }

        private void initGridSelect() {
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
                } else if (keyPress.Key == ConsoleKey.A && cursor.column > 0) {
                    cursor.column--;
                } else if (keyPress.Key == ConsoleKey.D && cursor.column < grid.GetLength(1) - 1) {
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

        public void printWithCursor() {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write(" ");
                    Console.Write(grid[r, c] ? "#" : "-");
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        private void printCursor() {
            int leftPosition = cursor.column * 3;
            int topPosition = cursor.row;

            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write("[");
            Console.SetCursorPosition(leftPosition + 2, topPosition);
            Console.Write("]");
            Console.SetCursorPosition(0, grid.GetLength(0));
        }

        private void removeOldCursorPosition() {
            int leftPosition = cursor.column * 3;
            int topPosition = cursor.row;

            Console.SetCursorPosition(leftPosition, topPosition);
            Console.Write(" ");
            Console.SetCursorPosition(leftPosition + 2, topPosition);
            Console.Write(" ");
            Console.SetCursorPosition(0, grid.GetLength(0));
        }

        public void reDraw() {
            if (didInitialDraw) {
                for (int r = 0; r < grid.GetLength(0); r++) {
                    for (int c = 0; c < grid.GetLength(1); c++) {
                        bool currentValue = grid[r, c];
                        bool lastDrawnValue = lastDraw[r, c];

                        if (currentValue != lastDrawnValue) {
                            Console.SetCursorPosition(left: (c * 3) + 1, top: r);

                            Console.Write(currentValue ? "#" : " ");

                            lastDraw[r, c] = currentValue;
                        }
                    }
                }

                Console.SetCursorPosition(left: 0, top: grid.GetLength(0));
            } else {
                throw new Exception("You need to do an initial draw to be able to redraw the plane");
            }
        }

        public void gameTick() {
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
                }
            }

            grid = nextGeneration;

            //printGrid();
        }
    }
}
