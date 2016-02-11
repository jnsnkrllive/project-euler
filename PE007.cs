using System.Collections.Generic;

namespace ProjectEuler {

    class PE007 {

        public static void execute() {
            System.Console.WriteLine("Problem 7:");
            System.Console.WriteLine("By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.");
            System.Console.WriteLine("What is the 10001st prime number?");
            System.Console.WriteLine();

            LinkedList<int> primes = new LinkedList<int>();
            int firstPrime = 2;
            int number = firstPrime;
            while(primes.Count < 10001) {
                bool isPrime = false;
                if (primes.Count > 0) {
                    isPrime = true;
                    foreach (int i in primes) {
                        if (number % i == 0) {
                            isPrime = false;
                            break;
                        }
                    }
                }
                else if (number == firstPrime) {
                    isPrime = true;
                }
                if (isPrime) {
                    primes.AddLast(number);
                }
                number++;
            }
            int answer = primes.Last.Value;

            System.Console.WriteLine("Answer is {0}", answer);
        }

    }

}
