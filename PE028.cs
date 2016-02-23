using System;

namespace ProjectEuler {

    class PE028 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 28:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:");
            Console.WriteLine("21 22 23 24 25");
            Console.WriteLine("20  7  8  9 10");
            Console.WriteLine("19  6  1  2 11");
            Console.WriteLine("18  5  4  3 12");
            Console.WriteLine("17 16 15 14 13");
            Console.WriteLine("It can be verified that the sum of the numbers on the diagonals is 101.");
            Console.WriteLine("What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?");
        }

        void PESolution.solve() {
            int sum = 1;
            int count = 1;
            int spiralSize = 1001;
            for (int i = 2; i <= (spiralSize / 2 + 1); i++) {
                for (int j = 1; j <= 4; j++) {
                    count += (2 * i - 2);
                    sum += count;
                }
            }
            Console.WriteLine("Answer is {0}", sum);
        }

    }

}
