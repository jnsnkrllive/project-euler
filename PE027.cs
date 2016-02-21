using System;

namespace ProjectEuler {

    class PE027 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 27:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Considering quadratics of the form:");
            Console.WriteLine("n ^2 + a*n + b, where |a| < 1000 and |b| < 1000");
            Console.WriteLine("where |n| is the modulus / absolute value of n");
            Console.WriteLine("Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.");
        }

        void PESolution.solve() {
            int answer = -1;
            // TODO
            Console.WriteLine("Answer is {0}", answer);
        }

    }

}
