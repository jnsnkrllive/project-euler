using System;
    
namespace ProjectEuler {

    class PE021 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 21:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).");
            Console.WriteLine("If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.");
            Console.WriteLine("For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.");
            Console.WriteLine("Evaluate the sum of all the amicable numbers under 10000.");
        }

        void PESolution.solve() {
            int sum = 0;
            int boundUpper = 10000;
            int[] dArray = new int[boundUpper];
            for (int i = 0; i < dArray.Length; i++) {
                int d = sumProperDivisorsOf(i);
                dArray[i] = d;
                if (d < i && dArray[d] == i) {
                    sum += (d + i);
                }
            }

            Console.WriteLine("Answer is {0}", sum);
        }

        private static int sumProperDivisorsOf(int n) {
            int limit = n;
            int result = 1;
            for (int i = 2; i < limit; i++) {
                if (n % i == 0) {
                    limit = n / i;
                    result += i + limit;
                }
            }
            return result;
        }

    }

}
