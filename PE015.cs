namespace ProjectEuler {

    class PE015 : PESolution {

        void PESolution.printProblemNumber() {
            System.Console.WriteLine("Problem 15:");
        }

        void PESolution.printProblemStatement() {
            System.Console.WriteLine("Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.");
            System.Console.WriteLine("How many such routes are there through a 20×20 grid?");
        }

        void PESolution.solve() {
            for (byte i = 0; i < MATRIX.Length; i++) {
                MATRIX[i] = new long[MATRIX_SIZE];
            }
            long answer = pathsToEndFromPoint(0, 0);

            System.Console.WriteLine("Answer is {0}", answer);
        }

        private static byte GRID_SIZE = 20;
        private static byte MATRIX_SIZE = (byte)(GRID_SIZE + 1);
        private static long[][] MATRIX = new long[MATRIX_SIZE][];

        private static long pathsToEndFromPoint(byte i, byte j) {
            if (MATRIX[i][j] != 0) {
                return MATRIX[i][j];
            }
            long pathsToEnd = 0;
            if (i == MATRIX_SIZE - 1 && j == MATRIX_SIZE - 1) {
                pathsToEnd = 1;
            }
            else if (i == MATRIX_SIZE - 1 && j != MATRIX_SIZE - 1) {
                pathsToEnd = 1;
            }
            else if (i != MATRIX_SIZE - 1 && j == MATRIX_SIZE - 1) {
                pathsToEnd = 1;
            }
            else {
                pathsToEnd = pathsToEndFromPoint((byte)(i + 1), j) + pathsToEndFromPoint(i, (byte)(j + 1));
            }
            MATRIX[i][j] = pathsToEnd;
            return pathsToEnd;
        }

    }

}
