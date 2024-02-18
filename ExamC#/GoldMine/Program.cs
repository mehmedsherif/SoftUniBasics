using System;

namespace GoldMining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < locationsCount; i++)
            {
                double expectedAverageGoldPerDay = double.Parse(Console.ReadLine());
                int miningDays = int.Parse(Console.ReadLine());

                double totalGold = 0;

                for (int day = 0; day < miningDays; day++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    totalGold += goldPerDay;
                }

                double averageGoldPerDay = totalGold / miningDays;

                if (averageGoldPerDay >= expectedAverageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGoldPerDay:f2}.");
                }
                else
                {
                    double goldNeeded = expectedAverageGoldPerDay-averageGoldPerDay;
                    Console.WriteLine($"You need {goldNeeded:f2} gold.");
                }
            }
        }
    }
}
