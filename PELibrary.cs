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

    }

}
