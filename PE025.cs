using System;

namespace ProjectEuler {

    class PE025 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 25:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("The Fibonacci sequence is defined by the recurrence relation:");
            Console.WriteLine("F[n] = F[n−1] + F[n−2], where F[1] = 1 and F[2] = 1.");
            Console.WriteLine("What is the index of the first term in the Fibonacci sequence to contain 1000 digits?");
        }

        void PESolution.solve() {
            int length = 1000;
            int[] fibMinusOne = new int[length];
            int[] fib = new int[length];
            fibMinusOne[0] = 1;
            fib[0] = 1;
            int fibIndex = 2;
            while (fib[length-1] == 0) {
                int carryover = 0;
                int[] tempFib = new int[length];
                fib.CopyTo(tempFib,0);
                for (int i = 0; i < length; i++) {
                    int newNumber = fibMinusOne[i] + tempFib[i];
                    fib[i] = PELibrary.getOnes(newNumber) + carryover;
                    carryover = PELibrary.getTens(newNumber);
                }
                tempFib.CopyTo(fibMinusOne, 0);
                fibIndex++;
            }

            Console.WriteLine("Answer is {0}", fibIndex);
        }

    }

}
