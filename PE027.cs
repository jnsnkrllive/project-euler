using System;

namespace ProjectEuler {

    class PE027 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 27:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Considering quadratics of the form:");
            Console.WriteLine("n^2 + a*n + b, where |a| < 1000 and |b| < 1000");
            Console.WriteLine("where |n| is the modulus / absolute value of n");
            Console.WriteLine("Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.");
        }

        void PESolution.solve() {
            int aMax = 0;
            int bMax = 0;
            int nMax = 0;
            int[] primes = PELibrary.getPrimesUpToLimit(111000);
            // Brute Force
            for (int a = -1000; a <= 1000; a++) {
                for (int b = -1000; b <= 1000; b++) {
                    int n = 0;
                    while (isPrime(n*n + a*n + b, primes)) {
                        n++;
                    }
                    if (n > nMax) {
                        aMax = a;
                        bMax = b;
                        nMax = n;
                    }
                }
            }
            int answer = aMax * bMax;
            Console.WriteLine("Answer is {0}", answer);
        }

        /**
         * Returns TRUE if the number is in the given sorted array of primes
         */
        private static bool isPrime(int number, int[] primes) {
            int i = 0;
            while (primes[i] <= number) {
                if (primes[i] == number) {
                    return true;
                }
                i++;
                System.Diagnostics.Debug.Assert(i < primes.Length);
            }
            return false;
        }

    }

}
