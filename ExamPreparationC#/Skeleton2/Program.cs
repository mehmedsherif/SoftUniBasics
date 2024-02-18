using System;

namespace Skeleton2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes=int.Parse(Console.ReadLine());
            int controlSeconds=int.Parse(Console.ReadLine());
            double trackInMeters=double.Parse(Console.ReadLine());
            int hundredMetersTime=int.Parse(Console.ReadLine());

            double controlAllSeconds = (controlMinutes * 60) + controlSeconds;
            double delayTime = (trackInMeters / 120) * 2.5;
            double playerTime = (trackInMeters / 100) * hundredMetersTime-delayTime;
        if(playerTime <=controlAllSeconds) 
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {playerTime:f3}.");
            }
        else
            {
                double moreTime = Math.Abs(controlAllSeconds - playerTime);
                Console.WriteLine($"No, Marin failed! He was {moreTime:f3} second slower.");
            }
        }
    }
}
