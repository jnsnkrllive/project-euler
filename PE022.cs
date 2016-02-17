using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectEuler {

    class PE022 : PESolution {

        void PESolution.printProblemNumber() {
            Console.WriteLine("Problem 22:");
        }

        void PESolution.printProblemStatement() {
            Console.WriteLine("Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.");
            Console.WriteLine("For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 938 × 53 = 49714.");
            Console.WriteLine("What is the total of all the name scores in the file?");
        }

        void PESolution.solve() {
            SortedSet<string> names = getData();
            int position = 1;
            int totalScore = 0;
            foreach (string n in names) {
                int value = getNameValue(n);
                totalScore += position * value;
                position++;
            }

            Console.WriteLine("Answer is {0}", totalScore);
        }

        private static SortedSet<string> getData() {
            string path = Path.GetFullPath(@"..\..\data\pe022_names.txt");
            string data = File.ReadAllText(path);
            string[] processed = data.Split(',');
            SortedSet<string> sortedData = new SortedSet<string>();
            for (int i = 0; i < processed.Length; i++) {
                sortedData.Add(processed[i].Substring(1, processed[i].Length - 2));
            }
            return sortedData;
        }

        private static int getNameValue(string name) {
            int value = 0;
            for (int i = 0; i < name.Length; i++) {
                value += charToNumber(char.ToUpper(name[i]));
            }
            return value;
        }

        private static int charToNumber(char c) {
            return c - 'A' + 1;
        }

    }

}
