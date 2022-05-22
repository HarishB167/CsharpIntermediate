using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCourse
{
    public class ExerciseStopwatch
    {
        public void run()
        {
            Console.WriteLine("Exercise stopwatch");

            var stopwatch = new StopWatch();

            while (true)
            {
                Console.Write("'start' or 'stop', 'q' to quit : ");

                var input = Console.ReadLine();

                if (input.Contains("q"))
                    return;

                if (input.Contains("start"))
                    stopwatch.Start();
                else if (input.Contains("stop"))
                    stopwatch.Stop();
            }
        }
    }

    public class StopWatch
    {
        private bool stopwatchRunning = false;
        private DateTime startTime;

        public void Start()
        {
            if (stopwatchRunning)
                throw new InvalidOperationException("Stopwatch is already started.");
            else
            {
                stopwatchRunning = true;
                startTime = DateTime.Now;
                Console.WriteLine("Stopwatch started");
            }
        }

        public void Stop()
        {
            if (stopwatchRunning)
            {
                stopwatchRunning = false;
                var timeSpan = DateTime.Now - startTime;
                Console.WriteLine("Stopwatch stopped");
                Console.WriteLine("Elapsed Time : {0} s", timeSpan.TotalSeconds);
            }
        }
    }

}
