using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //   Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
    //   provide two methods: Start and Stop.We call the start method first, and the stop method next.
    //   Then we ask the stopwatch about the duration between start and stop.Duration should be a
    //   value in TimeSpan.Display the duration on the console.
    //   We should also be able to use a stopwatch multiple times.So we may start and stop it and then
    //   start and stop it again. Make sure the duration value each time is calculated properly.
    //   We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
    //   start time). So the class should throw an InvalidOperationException if its started twice.


    class Stopwatch
    {
        public bool isTimeRunning = false;

        public DateTime start;

        public DateTime stop;

        public TimeSpan duration;


        public void StartTime(DateTime start)
        {
            isTimeRunning = true;
            this.start = DateTime.Now;
            Console.WriteLine("Stopwatch Started");
        }

        public void StopTime(DateTime stop)
        {
            this.stop = DateTime.Now;
            isTimeRunning = false;
            Console.WriteLine("Stopwatch Stopped");
        }

        public void Duration(DateTime start, DateTime stop)
        {
            duration = stop - start;
            Console.WriteLine("Duration is: " + duration);
        }
              
    }
}
