using System;

namespace Opdracht2 {
    class Program {
        Random random = new Random();
        InputMethods inputMethods = new InputMethods();

        static void Main(string[] args) {
            Program program = new Program();
            program.start();
        }

        void start() {
            int[,] matrix = new int[20, 20];

            initMatrixRandom(matrix, 1, 100);
            printMatrix(matrix);

            int query = inputMethods.readInt("Geef een getal om te zoeken: ");

            Position firstFoundPotition = searchMatrix(matrix, query);
            Position lastFoundPotition = searchMatrixLast(matrix, query);

            Console.WriteLine("Zoekgetal {0} komt als eerste voor op positie [{1},{2}]", query, firstFoundPotition.row, firstFoundPotition.column);
            Console.WriteLine("Zoekgetal {0} komt als eerste voor op positie [{1},{2}]", query, lastFoundPotition.row, lastFoundPotition.column);

            Console.ReadKey();
        }

        void initMatrixRandom(int[,] matrix, int min, int max) {
            for (int r = 0; r < matrix.GetLength(0); r++) {
                for (int c = 0; c < matrix.GetLength(1); c++) {
                    matrix[r, c] = random.Next(min, max + 1);
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

        Position searchMatrix(int[,] matrix, int query) {
            for (int c = 0; c < matrix.GetLength(1); c++) {
                for (int r = 0; r < matrix.GetLength(0); r++) {
                    int value = matrix[r, c];

                    if (value == query) {
                        return new Position {
                            row = r,
                            column = c
                        };
                    }
                }
            }

            return new Position();
        }

        Position searchMatrixLast(int[,] matrix, int query) {
            Position lastPosition = new Position();

            for (int c = 0; c < matrix.GetLength(1); c++) {
                for (int r = 0; r < matrix.GetLength(0); r++) {
                    int value = matrix[r, c];

                    if (value == query) {
                        lastPosition.column = c;
                        lastPosition.row = r;
                    }
                }
            }

            return lastPosition;
        }
    }

    class Position {
        public int row = -1;
        public int column = -1;
    }
}
