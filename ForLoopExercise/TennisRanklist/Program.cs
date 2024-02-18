using System;

namespace TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentsCount = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int totalPoints =0;
            int totalWins = 0;

            for (int i = 0; i < tournamentsCount; i++)
            {
                string stageReached = Console.ReadLine();

                if (stageReached == "W")
                {
                    totalPoints += 2000;
                    totalWins++;
                }
                else if (stageReached == "F")
                {
                    totalPoints += 1200;
                }
                else if (stageReached == "SF")
                {
                    totalPoints += 720;
                }
            }

            double averagePoints =Math.Floor((double)totalPoints/tournamentsCount);
            totalPoints+=startingPoints;
           
            double winPercentage = (double)totalWins / tournamentsCount * 100;

            Console.WriteLine("Final points: " + totalPoints);
            Console.WriteLine("Average points: " + averagePoints);
            Console.WriteLine($"{winPercentage:f2}%");
        }
    }
}
