using System.Collections.Generic;

namespace ProjectEuler {

    class PE019 {

        public static void execute() {
            printProblemStatement();

            Dictionary<int, int> daysInMonth = new Dictionary<int, int>();
            daysInMonth.Add( 1, 31);
            daysInMonth.Add( 2, 28);
            daysInMonth.Add( 3, 31);
            daysInMonth.Add( 4, 30);
            daysInMonth.Add( 5, 31);
            daysInMonth.Add( 6, 30);
            daysInMonth.Add( 7, 31);
            daysInMonth.Add( 8, 31);
            daysInMonth.Add( 9, 30);
            daysInMonth.Add(10, 31);
            daysInMonth.Add(11, 30);
            daysInMonth.Add(12, 31);

            int firstSundays = 0;
            int firstDayOfWeek = 1;
            for (int y = 1900; y <= 2000; y++) {
                for (int m = 1; m <= 12; m++) {
                    if (1901 <= y && y <= 2000) {
                        if (firstDayOfWeek == 0) {
                            firstSundays++;
                        }
                    }
                    int days = daysInMonth[m];
                    if (isLeapYear(y) && m == 2) {
                        days++;
                    }
                    firstDayOfWeek = (firstDayOfWeek + days + 1) % 7;   
                }
            }

            System.Console.WriteLine("Answer is {0}", firstSundays);
        }

        private static bool isLeapYear(int year) {
            if (year % 4 == 0) {
                if (year % 100 == 0) {
                    return (year % 400 == 0);
                }
                return true;
            }
            return false;
        }

        private static void printProblemStatement() {
            System.Console.WriteLine("Problem 19:");
            System.Console.WriteLine("You are given the following information, but you may prefer to do some research for yourself.");
            System.Console.WriteLine(">> 1 Jan 1900 was a Monday.");
            System.Console.WriteLine(">> Thirty days has September,");
            System.Console.WriteLine("   April, June and November.");
            System.Console.WriteLine("   All the rest have thirty - one,");
            System.Console.WriteLine("   Saving February alone,");
            System.Console.WriteLine("   Which has twenty - eight, rain or shine.");
            System.Console.WriteLine("   And on leap years, twenty - nine.");
            System.Console.WriteLine(">> A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.");
            System.Console.WriteLine("How many Sundays fell on the first of the month during the twentieth century(1 Jan 1901 to 31 Dec 2000)?");
            System.Console.WriteLine();
        }

    }

}
