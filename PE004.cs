using System;

namespace ProjectEuler {

    class PE004 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 4:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.");
            Console.WriteLine("Find the largest palindrome made from the product of two 3 - digit numbers.");
        }

        void PESolution.solve() {
            int largestPalindrome = -1;
            for (int i = 999; i > 99; i--) {
                for (int j = i; j > 99; j--) {
                    if (isPalindrome(i*j) &&
                        i*j > largestPalindrome) {
                        largestPalindrome = i * j;
                    }
                }
            }

            Console.WriteLine("Answer is {0}", largestPalindrome);
        }

        /**
         * Returns TRUE if the number is a palindrome
         */
        private static bool isPalindrome(int n) {
            string s = n.ToString();
            int last = s.Length-1;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != s[last - i]) {
                    return false;
                }
            }
            return true;
        }

    }

}
