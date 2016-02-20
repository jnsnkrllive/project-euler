using System;

namespace ProjectEuler {

    class PE026 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 26:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:");
            Console.WriteLine("1 / 2 = 0.5");
            Console.WriteLine("1 / 3 = 0.(3)");
            Console.WriteLine("1 / 4 = 0.25");
            Console.WriteLine("1 / 5 = 0.2");
            Console.WriteLine("1 / 6 = 0.1(6)");
            Console.WriteLine("1 / 7 = 0.(142857)");
            Console.WriteLine("1 / 8 = 0.125");
            Console.WriteLine("1 / 9 = 0.(1)");
            Console.WriteLine("1 / 10 = 0.1");
            Console.WriteLine("Where 0.1(6) means 0.166666..., and has a 1 - digit recurring cycle. It can be seen that 1 / 7 has a 6 - digit recurring cycle.");
            Console.WriteLine("Find the value of d < 1000 for which 1 / d contains the longest recurring cycle in its decimal fraction part.");
        }

        void PESolution.solve() {
            int dLongestRecurringCycle = 0;
            int longestRecurringCycleLength = 0;
            int boundUpper = 1000;
            for (int i = boundUpper-1; i > 1; i--) {
                int recurringCycleLength = findRecurringCycle(i);
                if (recurringCycleLength > longestRecurringCycleLength) {
                    longestRecurringCycleLength = recurringCycleLength;
                    dLongestRecurringCycle = i;
                }
            }

            Console.WriteLine("Answer is {0}", dLongestRecurringCycle);
        }

        private static int findRecurringCycle(int i) {
            int[] remainders = new int[i];
            int remainder = (10 * 1) % i;
            int count = 1;
            while (remainders[remainder] == 0) {
                remainders[remainder] = count++;
                remainder = (10 * remainder) % i;
                if (remainder == 0) {
                    return 0;
                }
            }
            return (count - remainders[remainder]);
        }

    }

}
