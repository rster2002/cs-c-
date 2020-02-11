using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perlin_Noise {
    class Program {
        static void Main(string[] args) {
            Random random = new Random(32);
            double[,] grid = new double[10, 10];

            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    grid[r, c] = perlinNoise(r, c, random);
                }
            }

            printGrid(grid);

            Console.ReadKey();
        }

        static double perlinNoise(double x, double y, Random random) {
            Point topLeft = new Point((int) x, (int) y);
            Point topRight = new Point((int) x + 1, (int) y);
            Point bottomLeft = new Point((int) x, (int) y + 1);
            Point bottomRight = new Point((int) x + 1, (int) y + 1);
            
            Vector topLeftVector = new Vector(randomVectorCoord(random), randomVectorCoord(random));
            Vector topRightVector = new Vector(randomVectorCoord(random), randomVectorCoord(random));
            Vector bottomLeftVector = new Vector(randomVectorCoord(random), randomVectorCoord(random));
            Vector bottomRightVector = new Vector(randomVectorCoord(random), randomVectorCoord(random));

            Vector topLeftDifference = new Vector(x - topLeft.x, y - topLeft.y);
            Vector topRightDifference = new Vector(x - topRight.x, y - topRight.y);
            Vector bottomLeftDifference = new Vector(x - bottomLeft.x, y - bottomLeft.y);
            Vector bottomRightDifference = new Vector(x - bottomRight.x, y - bottomRight.y);

            double dotProductTopLeft = dotProduct(topLeftVector, topLeftDifference);
            double dotProductTopRight = dotProduct(topRightVector, topRightDifference);
            double dotProductBottomLeft = dotProduct(bottomLeftVector, bottomLeftDifference);
            double dotProductBottomRight = dotProduct(bottomRightVector, bottomRightDifference);

            //printPoint(topLeft);
            //printPoint(topRight);
            //printPoint(bottomLeft);
            //printPoint(bottomRight);

            //printVector(topLeftVector);
            //printVector(topRightVector);
            //printVector(bottomLeftVector);
            //printVector(bottomRightVector);

            //printVector(topLeftDifference);
            //printVector(topRightDifference);
            //printVector(bottomLeftDifference);
            //printVector(bottomRightDifference);

            //Console.WriteLine(dotProductTopLeft);
            //Console.WriteLine(dotProductTopRight);
            //Console.WriteLine(dotProductBottomLeft);
            //Console.WriteLine(dotProductBottomRight);

            double lerpTop = lerp(dotProductTopLeft, dotProductTopRight, x);
            double lerpBottom = lerp(dotProductBottomLeft, dotProductBottomRight, x);

            return lerp(lerpTop, lerpBottom, y);
        }

        static double dotProduct(Vector vec1, Vector vec2) {
            double productX = vec1.x * vec2.x;
            double productY = vec1.y * vec2.y;

            return productX + productY;
        }

        static double randomVectorCoord(Random random) {
            return random.NextDouble() * 2 - 1;
        }

        static void printPoint(Point point) {
            Console.WriteLine("Point {0}, {1}", point.x, point.y);
        }

        static void printVector(Vector vector) {
            Console.WriteLine("Vector {0}, {1}", vector.x, vector.y);
        }

        static double lerp(double value1, double value2, double by) {
            return value1 * (1 - by) + value2 * by; ;
        }

        static void printGrid(double[,] grid) {
            for (int r = 0; r < grid.GetLength(0); r++) {
                for (int c = 0; c < grid.GetLength(1); c++) {
                    Console.Write("{0, 15} ", grid[r, c]);
                }

                Console.WriteLine();
            }
        }
    }
}
