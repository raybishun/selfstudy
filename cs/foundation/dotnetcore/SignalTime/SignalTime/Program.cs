using System;
using System.Timers;


namespace SignalTime
{
    class Program
    {
        static Timer timer;
        static void Main(string[] args)
        {
            DoWork(1000);
            Console.WriteLine("Press any key to abort.\n");
            Console.ReadKey();
        }

        static void DoWork(double seconds)
        {
            try
            {
                timer = new Timer(seconds);
                timer.Elapsed += OnTimerEvent;
                timer.AutoReset = true;
                timer.Enabled = true;
            }
            catch (Exception ex)
            {
                timer.Enabled = false;
                Console.WriteLine(ex.Message);
            }
        }

        private static void OnTimerEvent(object sender, ElapsedEventArgs e)
        {
            // Get the day/time when the Timer.Elapsed event was raised.
            Console.WriteLine($"{e.SignalTime}.");
        }
    }
}
