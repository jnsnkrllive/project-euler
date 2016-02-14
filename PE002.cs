﻿namespace ProjectEuler {

    class PE002 {

        public static void execute() {
            printProblemStatement();

            int highNumber = 4000000;
            int nMinusTwo = 0;
            int nMinusOne = 1;
            int sumEvenTerms = 0;
            while(nMinusOne < highNumber) {
                int n = nMinusOne + nMinusTwo;
                nMinusTwo = nMinusOne;
                nMinusOne = n;
                if (n%2 == 0) {
                    sumEvenTerms += n;
                }
            }

            System.Console.WriteLine("Answer is {0}", sumEvenTerms);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 2:");
            System.Console.WriteLine("Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:");
            System.Console.WriteLine("1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...");
            System.Console.WriteLine("By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.");
            System.Console.WriteLine();
        }

    }

}
