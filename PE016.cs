namespace ProjectEuler {

    class PE016 : PESolution {

        void PESolution.printProblemNumber() {
            System.Console.WriteLine("Problem 16:");
        }

        void PESolution.printProblemStatement() {
            System.Console.WriteLine("2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.");
            System.Console.WriteLine("What is the sum of the digits of the number 2^1000?");
        }

        void PESolution.solve() {
            int[] digits = new int[2 * System.Byte.MaxValue];
            digits[0] = 2;
            int targetExp = 1000;
            for (int i = 1; i < targetExp; i++) {
                int carryover = 0;
                for (int j = 0; j < digits.Length; j++) {
                    int newNumber = 2 * digits[j];
                    if (carryover > 0) {
                        digits[j] = newNumber % 10 + carryover;
                        carryover = 0;
                    }
                    else {
                        digits[j] = newNumber % 10;
                    }
                    if (newNumber > 9) {
                        carryover = newNumber / 10;
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) {
                sum += digits[i];
            }

            System.Console.WriteLine("Answer is {0}", sum);
        }

    }

}
