﻿using System;

namespace ProjectEuler {

    class PE012 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 12:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:");
            Console.WriteLine("1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...");
            Console.WriteLine("Let us list the factors of the first seven triangle numbers:");
            Console.WriteLine(" 1: 1");
            Console.WriteLine(" 3: 1,3");
            Console.WriteLine(" 6: 1,2,3,6");
            Console.WriteLine("10: 1,2,5,10");
            Console.WriteLine("15: 1,3,5,15");
            Console.WriteLine("21: 1,3,7,21");
            Console.WriteLine("28: 1,2,4,7,14,28");
            Console.WriteLine("We can see that 28 is the first triangle number to have over five divisors.");
            Console.WriteLine("What is the value of the first triangle number to have over five hundred divisors?");
        }

        void PESolution.solve() {
            int triangleNumber = 0;
            int divisors = 0;
            int i = 1;
            int targetDivisors = 500;
            while (divisors < targetDivisors) {
                triangleNumber += i++;
                if (triangleNumber < targetDivisors) {
                    continue;
                }
                divisors = countDivisors(triangleNumber);
            }

            Console.WriteLine("Answer is {0}", triangleNumber);
        }

        /**
         * Returns the number of divisors for a given number
         */
        private static int countDivisors(int n) {
            int limit = n;
            int count = 0;
            for (int i = 1; i < limit; i++) {
                if (n % i == 0) {
                    limit = n / i;
                    if (limit != i) {
                        count++;
                    }
                    count++;
                }
            }
            return count;
        }
        
    }

}
