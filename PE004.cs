namespace ProjectEuler {

    class PE004 {

        public static void execute() {
            printProblemStatement();

            int largestPalindrome = -1;
            for (int i = 999; i > 99; i--) {
                for (int j = i; j > 99; j--) {
                    if (isPalindrome(i*j) &&
                        i*j > largestPalindrome) {
                        largestPalindrome = i * j;
                    }
                }
            }

            System.Console.WriteLine("Answer is {0}", largestPalindrome);
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 4:");
            System.Console.WriteLine("A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.");
            System.Console.WriteLine("Find the largest palindrome made from the product of two 3 - digit numbers.");
            System.Console.WriteLine();
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
