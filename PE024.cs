using System;

namespace ProjectEuler {

    class PE024 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 24:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:");
            Console.WriteLine("012   021   102   120   201   210");
            Console.WriteLine("What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?");
        }

        void PESolution.solve() {
            string answer = getPermutationsOfPrefix(new char[10], 0);

            Console.WriteLine("Answer is {0}", answer);
        }

        private static bool[] DIGITS = new bool[10];
        private static int TARGET = 1000000;
        private static int permutationNumber = 0;

        private static string getPermutationsOfPrefix(char[] prefix, int position) {
            if (position == prefix.Length) {
                permutationNumber++;
            }
            if (permutationNumber == TARGET) {
                return new string(prefix);
            }
            for (int i = 0; i < DIGITS.Length; i++) {
                if (!DIGITS[i]) {
                    prefix[position] = i.ToString().ToCharArray()[0];
                    DIGITS[i] = true;
                    string result = getPermutationsOfPrefix(prefix, position + 1);
                    if (result.Length > 0) {
                        return result;
                    }
                    DIGITS[i] = false;
                }
            }
            return "";
        }

    }

}
