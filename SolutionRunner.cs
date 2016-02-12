using System;
using System.Diagnostics;

namespace ProjectEuler {

    /**
     * @link https://projecteuler.net/
     */

    class SolutionRunner {

        static void Main(string[] args) {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            PE010.execute();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Run Time: {0}", elapsedTime);
        }

    }

}
