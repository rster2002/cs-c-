namespace CandyCrushLogic {
    public class CandyCrusher {
        public static bool checkScoreRowPresent(RegularCandy[,] grid) {
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

        public static bool checkScoreColumnPresent(RegularCandy[,] grid) {
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
