using System;
using System.Diagnostics;

namespace ProjectEuler {

    /**
     * @link https://projecteuler.net/
     */

    class SolutionRunner {

        static void Main(string[] args) {
            executeSingle("031");
            //executeAll();
        }

        static void executeAll() {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            PESolution pesol;
            for (int i = 0; i < SOLUTIONS.Length; i++) {
                Console.WriteLine("Problem {0}: ", SOLUTIONS[i]);
                pesol = (PESolution) assembly.CreateInstance("ProjectEuler.PE" + SOLUTIONS[i]);
                timedSolve(pesol);
                Console.WriteLine();
            }
        }

        static void executeSingle(String solution) {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            PESolution pesol = (PESolution) assembly.CreateInstance("ProjectEuler.PE" + solution);
            pesol.printProblemNumber();
            pesol.printProblemStatement();
            Console.WriteLine();
            timedSolve(pesol);
        }

        private static void timedSolve(PESolution pesol) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            pesol.solve();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine("Run Time: {0}", elapsedTime);
        }

        private static String[] SOLUTIONS = new String[] {
                   "001", "002", "003", "004", "005", "006", "007", "008", "009",
            "010", "011", "012", "013", "014", "015", "016", "017", "018", "019",
            "020", "021", "022", "023", "024", "025", "026", "027", "028", "029",
            "030", "031",
            "067",
        };

    }

}
