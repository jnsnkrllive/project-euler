namespace ProjectEuler {

    class PE010 {

        private static int FIRST_PRIME = 2;

        public static void execute() {
            System.Console.WriteLine("Problem 10:");
            System.Console.WriteLine("The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.");
            System.Console.WriteLine("Find the sum of all the primes below two million.");
            System.Console.WriteLine();

            int boundUpper = 2000000;
            bool[] primes = new bool[boundUpper];
            primes[0] = false;
            primes[1] = false;
            primes[FIRST_PRIME] = true;
            for (int i = FIRST_PRIME; i < primes.Length; i++) {
                primes[i] = true;
            }
            for (int i = FIRST_PRIME; i < primes.Length; i++) {
                if (!primes[i]) {
                    continue;
                }
                if (isPrime(i, primes)) {
                    primes[i] = true;
                    for (int j = i + i; j < primes.Length; j = j + i) {
                        primes[j] = false;
                    }
                }
            }
            long sum = 0;
            for (int i = 0; i < primes.Length; i++) {
                if (primes[i]) {
                    sum += i;
                }
            }

            System.Console.WriteLine("Answer is {0}", sum);
        }

        /**
         * Returns TRUE if the given number is prime
         */
        private static bool isPrime(int n, bool[] primes) {
            for (int i = FIRST_PRIME; i < n/2; i++) {
                if (!primes[i]) {
                    // 'i' is not prime, so skip it
                    continue;
                }
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }

    }

}
