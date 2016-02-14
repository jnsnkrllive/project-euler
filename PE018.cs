namespace ProjectEuler {

    class PE018 : PESolution {

        void PESolution.printProblemNumber() {
            System.Console.WriteLine("Problem 18:");
        }

        void PESolution.printProblemStatement() {
            System.Console.WriteLine("By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.");
            System.Console.WriteLine("   3   ");
            System.Console.WriteLine("  7 4  ");
            System.Console.WriteLine(" 2 4 6 ");
            System.Console.WriteLine("8 5 9 3");
            System.Console.WriteLine("That is, 3 + 7 + 4 + 9 = 23.");
            System.Console.WriteLine("Find the maximum total from top to bottom of the triangle below:");
        }

        void PESolution.solve() {
            int[] maxPath = new int[TRIANGE.Length];
            for (int i = TRIANGE.Length - 1; i >= 0; i--) {
                if (getChildLeft(i) >= TRIANGE.Length) {
                    maxPath[i] = TRIANGE[i];
                }
                else {
                    maxPath[i] = System.Math.Max(maxPath[getChildLeft(i)], maxPath[getChildRight(i)]) + TRIANGE[i];
                }
            }

            System.Console.WriteLine("Answer is {0}", maxPath[0]);
        }
        
        private static int getChildLeft(int i) {
            return getRow(i) + i;
        }

        private static int getChildRight(int i) {
            return getChildLeft(i) + 1;
        }

        private static int getRow(int i) {
            int row = 0;
            int limit = i;
            for (int n = 0; n <= limit; n++) {
                row++;
                limit -= n;
            }
            return row;
        }

        private static byte[] TRIANGE = new byte[] {
            75,
            95, 64,
            17, 47, 82,
            18, 35, 87, 10,
            20, 04, 82, 47, 65,
            19, 01, 23, 75, 03, 34,
            88, 02, 77, 73, 07, 63, 67,
            99, 65, 04, 28, 06, 16, 70, 92,
            41, 41, 26, 56, 83, 40, 80, 70, 33,
            41, 48, 72, 33, 47, 32, 37, 16, 94, 29,
            53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14,
            70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57,
            91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48,
            63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31,
            04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23
        };

    }

}
