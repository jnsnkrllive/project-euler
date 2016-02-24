using System;

namespace ProjectEuler {

    class PE030 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 30:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.");
        }

        void PESolution.solve() {
            int[] fifths = new int[10];
            for (int i = 0; i < fifths.Length; i++) {
                fifths[i] = Convert.ToInt32(Math.Pow(i, 5));
            }
            int total = 0;
            int boundUpper = 355000;
            // Brute Force
            for (int i = 2; i < boundUpper; i++) {
                char[] number = i.ToString().ToCharArray();
                int sum = 0;
                for (int j = 0; j < number.Length; j++) {
                    sum += fifths[Convert.ToByte(char.GetNumericValue(number[j]))];
                }
                if (sum == i) {
                    total += i;
                }
            }

            Console.WriteLine("Answer is {0}", total);
        }

    }

}
