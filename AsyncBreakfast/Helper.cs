using System;
using System.Diagnostics;

namespace AsyncBreakfast
{
    public static class Helper
    {
        public static void StartTime(Stopwatch stopwatch)
        {
            stopwatch.Start();
        }

        public static void StopTimeAndView(Stopwatch stopWatch)
        {
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            var ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            var elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}