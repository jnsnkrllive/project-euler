using System.Collections.Generic;

namespace ProjectEuler {

    class PE007 {

        public static void execute() {
            System.Console.WriteLine("Problem 7:");
            System.Console.WriteLine("By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.");
            System.Console.WriteLine("What is the 10001st prime number?");
            System.Console.WriteLine();

            SortedSet<int> primes = new SortedSet<int>();
            int firstPrime = 2;
            int number = firstPrime;
            while (primes.Count < 10001) {
                bool isNumberPrime = false;
                if (primes.Count > 0) {
                    isNumberPrime = isPrime(number, primes);
                }
                else if (number == firstPrime) {
                    isNumberPrime = true;
                }
                if (isNumberPrime) {
                    primes.Add(number);
                }
                number++;
            }
            int answer = primes.Max;

            System.Console.WriteLine("Answer is {0}", answer);
        }

        /**
         * Returns TRUE if the given number is prime
         */
        private static bool isPrime(int n, SortedSet<int> primes) {
            System.Diagnostics.Debug.Assert(n > primes.Max);
            foreach (int i in primes) {
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }

    }

}
