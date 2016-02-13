namespace ProjectEuler {

    class PE014 {

        public static void execute() {
            printProblemStatement();

            // TODO
            int answer = -1;

            System.Console.WriteLine("Answer is {0}", answer);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 14:");
            System.Console.WriteLine("The following iterative sequence is defined for the set of positive integers:");
            System.Console.WriteLine("n -> n/2 (n is even)");
            System.Console.WriteLine("n -> 3n + 1 (n is odd)");
            System.Console.WriteLine("Using the rule above and starting with 13, we generate the following sequence:");
            System.Console.WriteLine("13 -> 40 -> 20 -> 10 -> 5 -> 16 -> 8 -> 4 -> 2 -> 1");
            System.Console.WriteLine("It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.");
            System.Console.WriteLine("Which starting number, under one million, produces the longest chain?");
            System.Console.WriteLine("NOTE: Once the chain starts the terms are allowed to go above one million.");
            System.Console.WriteLine();
        }

    }

}
