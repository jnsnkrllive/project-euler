namespace ProjectEuler {

    class PE003 {

        public static void execute() {
            printProblemStatement();

            long targetNumber = 600851475143;
            long largestPrimeFactor = -1;

            long maxValue = targetNumber;
            for (long i = 1; i < maxValue; i++) {
                if (targetNumber % i == 0) {
                    maxValue = targetNumber / i;
                    if (isPrime(i)) {
                        largestPrimeFactor = i;
                    }
                }
            }

            System.Console.WriteLine("Answer is {0}", largestPrimeFactor);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 3:");
            System.Console.WriteLine("The prime factors of 13195 are 5, 7, 13 and 29.");
            System.Console.WriteLine("What is the largest prime factor of the number 600851475143?");
            System.Console.WriteLine();
        }

        /**
         * Returns TRUE if the given number is prime
         */
        private static bool isPrime(long n) {
            for (long i = 2; i < n / 2; i++) {
                if (n % i == 0) {
                    return false;
                }
            }
            return true;
        }

    }

}
