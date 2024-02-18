using System;

namespace WatchingSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName=Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime / 8.0;
            double recreationTime = breakTime / 4.0;
            double overallTime = breakTime - (lunchTime+ recreationTime);

            if (overallTime>=episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(overallTime - episodeTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeTime - overallTime)} more minutes.");
            }
        }
    }

}
   
