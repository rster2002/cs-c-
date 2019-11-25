using System;

namespace Opdracht1 {
    class Program {
        static void Main(string[] args) {
            Program program = new Program();
            program.start();

            Console.ReadKey();
        }

        void start() {
            int[,] matrix = new int[30, 30];

            initMatrixLinear(matrix);
            printMatrixWithCross(matrix);
        }

        void initMatrix(int[,] matrix) {
            int iterator = 0;

            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    iterator++;

                    matrix[r, c] = iterator;
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
        
        void initMatrixLinear(int[,] matrix) {
            for (int i = 0; i < matrix.Length; i++) {
                int row = i / matrix.GetLength(0);
                int column = i % matrix.GetLength(1);

                matrix[row, column] = i + 1;
            }
        }

        void printMatrixWithCross(int[,] matrix) {
            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    if (r == c) {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    if (matrix.GetLength(0) - r == c + 1) {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }

                    Console.Write("{0, 3} ", matrix[r, c]);
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}
