using System;

namespace ANDProcessors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int processorNeeded=int.Parse(Console.ReadLine());
            int workerCount=int.Parse(Console.ReadLine());
            int workDays=int.Parse(Console.ReadLine());

            int workHour = workerCount * workDays * 8;
            int madedPr =workHour / 3;
            double plannedRevenue = processorNeeded * 110.10;
            double actualRevenue = madedPr * 110.10;
            

            if(madedPr>processorNeeded)
            {
                double profit = actualRevenue - plannedRevenue;
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
            else 
            {
                double loose=plannedRevenue - actualRevenue;
                Console.WriteLine($"Losses: -> {loose:f2} BGN");
            }
        }
    }
}
