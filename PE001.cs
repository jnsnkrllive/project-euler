namespace ProjectEuler {

    class PE001 {

        public static void execute() {
            printProblemStatement();

            int highNumber = 1000;
            int sum = 0;
            for (int i = 0; i < highNumber; i++) {
                if (i % 3 == 0 || i % 5 == 0) {
                    sum += i;
                }
            }

            System.Console.WriteLine("Answer is {0}", sum);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 1:");
            System.Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            System.Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            System.Console.WriteLine();
        }

    }

}
