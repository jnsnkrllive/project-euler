using System;

namespace ProjectEuler {

    class PE009 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 9:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,");
            Console.WriteLine("a^2 + b^2 = c^2");
            Console.WriteLine("For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.");
            Console.WriteLine("There exists exactly one Pythagorean triplet for which a + b + c = 1000.");
            Console.WriteLine("Find the product abc.");
        }

        void PESolution.solve() {
            int product = 0;
            for (int i = 1; i < 499; i++) {
                for (int j = i+1; j < 999; j++) {
                    int k = 1000 - i - j;
                    if (isPythagoreanTriplet(i, j, k) &&
                        product < i * j * k) {
                        product = i * j * k;
                    }
                }
            }
            
            Console.WriteLine("Answer is {0}", product);
        }
        
        /**
         * Returns TRUE if the triplet (a,b,c) is a "Pathagorean Triplet"
         */
        private static bool isPythagoreanTriplet(int a, int b, int c) {
            if (!(a < b) || !(b < c)) {
                return false;
            }
            return (a * a + b * b == c * c);
        }

    }

}
