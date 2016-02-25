using System;

namespace ProjectEuler {

    class PE031 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 31:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:");
            Console.WriteLine("1p, 2p, 5p, 10p, 20p, 50p, £1(100p) and £2(200p).");
            Console.WriteLine("It is possible to make £2 in the following way:");
            Console.WriteLine("1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p");
            Console.WriteLine("How many different ways can £2 be made using any number of coins?");
        }

        void PESolution.solve() {
            int[] coinValues = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int target = 200;
            int[] ways = new int[target + 1];
            ways[0] = 1;
            for (int i = 0; i < coinValues.Length; i++) {
                for (int j = coinValues[i]; j <= target; j++) {
                    ways[j] += ways[j - coinValues[i]];
                }
            }
            int answer = ways[ways.Length - 1];

            Console.WriteLine("Answer is {0}", answer);
        }

    }

}
