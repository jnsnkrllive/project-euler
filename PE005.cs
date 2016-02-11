namespace ProjectEuler {

    class PE005 {

        public static void execute() {
            System.Console.WriteLine("Problem 5:");
            System.Console.WriteLine("2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.");
            System.Console.WriteLine("What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?");
            System.Console.WriteLine();

            int smallestMultiple = -1;
            int rangeMin = 1;
            int rangeMax = 20;
            int testNumber = rangeMax;
            while (smallestMultiple < 0) {
                if (checkMultiple(testNumber, rangeMin, rangeMax)) {
                    smallestMultiple = testNumber;
                }
                testNumber++;
            }

            System.Console.WriteLine("The smallest positive number evenly divisible by all numbers from {0} to {1} is {2}", rangeMin, rangeMax, smallestMultiple);
        }

        /**
         * Returns TRUE if n is evenly divisible by all numbers from min to max
         */
        private static bool checkMultiple(int n, int min, int max) {
            for (int i = min; i <= max; i++) {
                if (!isEvenlyDivisible(n, i)) {
                    return false;
                }
            }
            return true;
        }

        /**
         * Returns TRUE if n is evenly divisible by d
         */
        private static bool isEvenlyDivisible(int n, int d) {
            return (n % d == 0);
        }

    }

}
