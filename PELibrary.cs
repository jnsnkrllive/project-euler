using System;
using System.Collections;

namespace ProjectEuler {

    class PELibrary {

        private static int getPlaceValue(int number, int place) {
            int valueOfPlace = (int) System.Math.Pow(10, place - 1);
            if (number < valueOfPlace) {
                return 0;
            }
            return (number / valueOfPlace) % 10;
        }

        public static int getOnes(int n) {
            return getPlaceValue(n, 1);
        }

        public static int getTens(int n) {
            return getPlaceValue(n, 2);
        }

        public static int getHundreds(int n) {
            return getPlaceValue(n, 3);
        }

        public static int getThousands(int n) {
            return getPlaceValue(n, 4);
        }

        /**
         * Sieve of Eratosthenes
         * Returns an array of primes up to a given limit
         */
        public static int[] getPrimesUpToLimit(int boundUpper) {
            // Initialze numbers array
            bool[] numbers = new bool[boundUpper];
            for (int i = 2; i < numbers.Length; i++) {
                numbers[i] = true;
            }
            // Perform Algorithm
            ArrayList primes = new ArrayList();
            for (int i = 0; i < numbers.Length; i++) {
                if (!numbers[i]) {
                    continue;
                }
                primes.Add(i);
                if (i < Math.Sqrt(numbers.Length)) {
                    for (int j = i; j < numbers.Length; j = j + i) {
                        numbers[j] = false;
                    }
                }
            }
            // Return Primes as Array
            return (int[])primes.ToArray(typeof(int));
        }

    }

}
