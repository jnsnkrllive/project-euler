using System;
using System.Collections.Generic;

namespace ProjectEuler {

    class PE019 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 19:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("You are given the following information, but you may prefer to do some research for yourself.");
            Console.WriteLine(">> 1 Jan 1900 was a Monday.");
            Console.WriteLine(">> Thirty days has September,");
            Console.WriteLine("   April, June and November.");
            Console.WriteLine("   All the rest have thirty - one,");
            Console.WriteLine("   Saving February alone,");
            Console.WriteLine("   Which has twenty - eight, rain or shine.");
            Console.WriteLine("   And on leap years, twenty - nine.");
            Console.WriteLine(">> A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.");
            Console.WriteLine("How many Sundays fell on the first of the month during the twentieth century(1 Jan 1901 to 31 Dec 2000)?");
        }

        void PESolution.solve() {
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

            Console.WriteLine("Answer is {0}", firstSundays);
        }

        /**
         * Returns TRUE if the given year is a leap year
         */
        private static bool isLeapYear(int year) {
            if (year % 4 == 0) {
                if (year % 100 == 0) {
                    return (year % 400 == 0);
                }
                return true;
            }
            return false;
        }

    }

}
