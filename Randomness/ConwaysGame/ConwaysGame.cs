using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame {
    class ConwaysGame {
        public getInput() {

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
    }
}
