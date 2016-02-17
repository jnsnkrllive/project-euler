using System;


namespace ProjectEuler {

    class PE010 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 10:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.");
            Console.WriteLine("Find the sum of all the primes below two million.");
        }

        void PESolution.solve() {
            int boundUpper = 2000000;
            bool[] primes = new bool[boundUpper];
            primes[0] = false;
            primes[1] = false;
            primes[FIRST_PRIME] = true;
            // Initialze array
            for (int i = FIRST_PRIME; i < primes.Length; i++) {
                primes[i] = true;
            }
            // Calculate primes
            for (int i = FIRST_PRIME; i < primes.Length; i++) {
                if (!primes[i]) {
                    continue;
                }
                for (int j = i + i; j < primes.Length; j = j + i) {
                    primes[j] = false;
                }
            }
            // Sum primes
            long sum = 0;
            for (int i = 0; i < primes.Length; i++) {
                if (primes[i]) {
                    sum += i;
                }
            }

            Console.WriteLine("Answer is {0}", sum);
        }

        private static int FIRST_PRIME = 2;

    }

}
