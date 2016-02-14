using System.Collections.Generic;
    
namespace ProjectEuler {

    class PE017 : PESolution {

        void PESolution.printProblemNumber() {
            System.Console.WriteLine("Problem 17:");
        }

        void PESolution.printProblemStatement() {
            System.Console.WriteLine("If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.");
            System.Console.WriteLine("If all the numbers from 1 to 1000(one thousand) inclusive were written out in words, how many letters would be used?");
            System.Console.WriteLine("NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of \"and\" when writing out numbers is in compliance with British usage.");
        }

        void PESolution.solve() {
            // Initialize map that defines the length of the cardinal numbers used in this calculation
            cardinalLength.Add(1, "one".Length);
            cardinalLength.Add(2, "two".Length);
            cardinalLength.Add(3, "three".Length);
            cardinalLength.Add(4, "four".Length);
            cardinalLength.Add(5, "five".Length);
            cardinalLength.Add(6, "six".Length);
            cardinalLength.Add(7, "seven".Length);
            cardinalLength.Add(8, "eight".Length);
            cardinalLength.Add(9, "nine".Length);
            cardinalLength.Add(10, "ten".Length);
            cardinalLength.Add(11, "eleven".Length);
            cardinalLength.Add(12, "twelve".Length);
            cardinalLength.Add(13, "thirteen".Length);
            cardinalLength.Add(14, "fourteen".Length);
            cardinalLength.Add(15, "fifteen".Length);
            cardinalLength.Add(16, "sixteen".Length);
            cardinalLength.Add(17, "seventeen".Length);
            cardinalLength.Add(18, "eighteen".Length);
            cardinalLength.Add(19, "nineteen".Length);
            cardinalLength.Add(20, "twenty".Length);
            cardinalLength.Add(30, "thirty".Length);
            cardinalLength.Add(40, "forty".Length);
            cardinalLength.Add(50, "fifty".Length);
            cardinalLength.Add(60, "sixty".Length);
            cardinalLength.Add(70, "seventy".Length);
            cardinalLength.Add(80, "eighty".Length);
            cardinalLength.Add(90, "ninety".Length);
            cardinalLength.Add(100, "hundredand".Length);
            cardinalLength.Add(1000, "thousand".Length);
            // Perform Calculation
            int answer = 0;
            int boundUpper = 1000;
            for (int i = 1; i <= boundUpper; i++) {
                answer += numberOfLetters(i);
            }

            System.Console.WriteLine("Answer is {0}", answer);
        }

        private static Dictionary<int, int> cardinalLength = new Dictionary<int, int>();

        private static int numberOfLetters(int n) {
            int ones = getOnes(n);
            int tens = getTens(n);
            int hundreds = getHundreds(n);
            int thousands = getThousands(n);
            int count = 0;
            // Add for x1-99
            if (tens == 0) {
                if (ones != 0) {
                    count += cardinalLength[ones];
                }
            }
            else if (tens == 1) {
                count += cardinalLength[tens * 10 + ones];
            }
            else {
                count += cardinalLength[10 * tens];
                if (ones > 0) {
                    count += cardinalLength[ones];
                }
            }
            // Add for x100-999
            if (hundreds != 0) {
                count += cardinalLength[hundreds] + cardinalLength[100];
                if (ones == 0 && tens == 0) {
                    count -= "and".Length;
                }
            }
            // Add for x1000+
            if (thousands != 0) {
                count += cardinalLength[thousands] + cardinalLength[1000];
            }
            return count;
        }

        private static int getOnes(int n) {
            if (n < 1) {
                return 0;
            }
            return (n / 1) % 10;
        }

        private static int getTens(int n) {
            if (n < 10) {
                return 0;
            }
            return (n / 10) % 10;
        }

        private static int getHundreds(int n) {
            if (n < 100) {
                return 0;
            }
            return (n / 100) % 10;
        }

        private static int getThousands(int n) {
            if (n < 1000) {
                return 0;
            }
            return (n / 1000) % 10;
        }

    }

}
