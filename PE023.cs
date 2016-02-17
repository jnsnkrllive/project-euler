using System;

namespace ProjectEuler {

    class PE023 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 23:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.");
            Console.WriteLine("A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.");
            Console.WriteLine("As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.");
            Console.WriteLine("Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.");
        }

        void PESolution.solve() {
            int boundUpper = 28123;
            bool[] isAbundant = new bool[boundUpper+1];
            bool[] isSumOfTwoAbundants = new bool[boundUpper+1];
            for (int i = 0; i <= boundUpper; i++) {
                if (sumDivisors(i) > i) {
                    isAbundant[i] = true;
                    for (int j = i; j > 0; j--) {
                        if (isAbundant[j] && i + j <= boundUpper) {
                            isSumOfTwoAbundants[i + j] = true;
                        }
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < isSumOfTwoAbundants.Length; i++) {
                if (!isSumOfTwoAbundants[i]) {
                    sum += i;
                }
            }

            Console.WriteLine("Answer is {0}", sum);
        }

        // This is very similar to PE021.sumProperDivisorsOf(int)
        private static int sumDivisors(int n) {
            int limit = n;
            int result = 0;
            if (n > 1) {
                result++;
            }
            for (int i = 2; i < limit; i++) {
                if (n % i == 0) {
                    limit = n / i;
                    if (i == limit) {
                        result += i;
                    }
                    else {
                        result += i + limit;
                    }
                }
            }
            return result;
        }

    }

}
