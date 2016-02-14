namespace ProjectEuler {

    class PE006 {

        public static void execute() {
            printProblemStatement();

            int numberMin = 1;
            int numberMax = 100;
            int sum = 0;
            long sumOfSquares = 0;
            for (int i = numberMin; i <= numberMax; i++) {
                sum += i;
                sumOfSquares += (i * i);
            }
            long squareOfSums = sum * sum;
            long difference = System.Math.Abs(squareOfSums - sumOfSquares);

            System.Console.WriteLine("Answer is {0}", difference);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 6:");
            System.Console.WriteLine("The sum of the squares of the first ten natural numbers is,");
            System.Console.WriteLine("1^2 + 2^2 + ... + 10^2 = 385");
            System.Console.WriteLine("The square of the sum of the first ten natural numbers is,");
            System.Console.WriteLine("(1 + 2 + ... + 10)^2 = 552 = 3025");
            System.Console.WriteLine("Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.");
            System.Console.WriteLine("Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.");
            System.Console.WriteLine();
        }

    }

}
