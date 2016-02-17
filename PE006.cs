using System;

namespace ProjectEuler {

    class PE006 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 6:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("The sum of the squares of the first ten natural numbers is,");
            Console.WriteLine("1^2 + 2^2 + ... + 10^2 = 385");
            Console.WriteLine("The square of the sum of the first ten natural numbers is,");
            Console.WriteLine("(1 + 2 + ... + 10)^2 = 552 = 3025");
            Console.WriteLine("Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.");
            Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
        }

        void PESolution.solve() {
            int numberMin = 1;
            int numberMax = 100;
            int sum = 0;
            long sumOfSquares = 0;
            for (int i = numberMin; i <= numberMax; i++) {
                sum += i;
                sumOfSquares += (i * i);
            }
            long squareOfSums = sum * sum;
            long difference = Math.Abs(squareOfSums - sumOfSquares);

            Console.WriteLine("Answer is {0}", difference);
        }

    }

}
