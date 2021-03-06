﻿using System;

namespace ProjectEuler {

    class PE020 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 20:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("n! means n × (n − 1) × ... × 3 × 2 × 1");
            Console.WriteLine("For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800, and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.");
            Console.WriteLine("Find the sum of the digits in the number 100!");
        }

        void PESolution.solve() {
            int[] digits = new int[159];
            digits[0] = 1;
            int targetNumber = 100;
            for (int i = 1; i <= targetNumber; i++) {
                int[] carryover = new int[digits.Length + 2];
                for (int j = 0; j < digits.Length; j++) {
                    int newNumber = i * digits[j];
                    carryover[j + 1] += PELibrary.getTens(newNumber) + PELibrary.getTens(PELibrary.getOnes(newNumber) + carryover[j]);
                    carryover[j + 2] += PELibrary.getHundreds(newNumber);
                      digits[j] = PELibrary.getOnes(PELibrary.getOnes(newNumber) + carryover[j]);
                }
            }
            int sum = 0;
            for (int i = 0; i < digits.Length; i++) {
                sum += digits[i];
            }

            Console.WriteLine("Answer is {0}", sum);
        }

    }

}
