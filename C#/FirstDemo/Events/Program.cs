using System;
using System.Timers;
namespace Events
{
    class MainClass
    {
        static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);

        }


        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}",e.SignalTime);
        }


        public static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed +=MyTimer_Elapsed;
            myTimer.Elapsed +=MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press enter to remove the red event.");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            Console.ReadLine();
        }
    }
}
