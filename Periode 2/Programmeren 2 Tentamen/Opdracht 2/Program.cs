using System;

namespace Opdracht_2 {
    class Program {
        const int matrixRows = 15;
        const int matrixColumns = 20;
        const int randomRangeMin = 1;
        const int randomRangeMax = 200;

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            int[,] matrix = new int[matrixRows, matrixColumns];

            fillMatrixRandomly(matrix);
            printMatrix(matrix);

            Position smallestValuePosition = searchMin(matrix);
            Position biggestValuePosition = searchMax(matrix);

            Console.WriteLine();

            showPosition("Kleinste", smallestValuePosition);
            showPosition("Grootste", biggestValuePosition);

            Console.WriteLine();

            printMatrixPositions(matrix, smallestValuePosition, biggestValuePosition);

            Console.ReadKey();
        }

        void fillMatrixRandomly(int[,] matrix) {
            Random random = new Random();

            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    int randomNumber = random.Next(randomRangeMin, randomRangeMax + 1);
                    matrix[r, c] = randomNumber;
                }
            }
        }

        void printMatrix(int[,] matrix) {
            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    Console.Write("{0, 3} ", matrix[r, c]);
                }

                Console.WriteLine();
            }
        }

        void showPosition(string name, Position position) {
            Console.WriteLine(
                "{0}: {1} (rij: {2}, kolom: {3})",
                name,
                position.value,
                position.row,
                position.column
            );
        }

        Position searchMin(int[,] matrix) {
            Position lowestValuePosition = new Position() {
                value = randomRangeMax
            };

            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    int currentValue = matrix[r, c];

                    if (currentValue < lowestValuePosition.value) {
                        lowestValuePosition.value = currentValue;
                        lowestValuePosition.row = r;
                        lowestValuePosition.column = c;

                        if (lowestValuePosition.value == randomRangeMin) {
                            return lowestValuePosition;
                        }
                    }
                }
            }

            return lowestValuePosition;
        }

        Position searchMax(int[,] matrix) {
            Position biggestValuePosition = new Position() {
                value = randomRangeMin
            };

            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    int currentValue = matrix[r, c];

                    if (currentValue > biggestValuePosition.value) {
                        biggestValuePosition.value = currentValue;
                        biggestValuePosition.row = r;
                        biggestValuePosition.column = c;

                        if (biggestValuePosition.value == randomRangeMax) {
                            return biggestValuePosition;
                        }
                    }
                }
            }

            return biggestValuePosition;
        }

        void printMatrixPositions(int[,] matrix, Position smallestValuePosition, Position biggestValuePosition) {
            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    int currentValue = matrix[r, c];

                    if (r == smallestValuePosition.row || c == smallestValuePosition.column) {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                    }

                    if (r == biggestValuePosition.row || c == biggestValuePosition.column) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (currentValue == smallestValuePosition.value) {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    if (currentValue == biggestValuePosition.value) {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write("{0, 3} ", matrix[r, c]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
