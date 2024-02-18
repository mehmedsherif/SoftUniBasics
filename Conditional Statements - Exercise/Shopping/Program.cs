using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numVideoCards = int.Parse(Console.ReadLine());
            int numProcessors = int.Parse(Console.ReadLine());
            int numRamMemory = int.Parse(Console.ReadLine());
            double priceVideoCard = numVideoCards * 250;
            double priceProcessors = numProcessors * (priceVideoCard * 0.35);
            double priceRamMemory = numRamMemory * (priceVideoCard * 0.1);
            double sum = priceVideoCard + priceProcessors + priceRamMemory;

            if (numVideoCards > numProcessors)
            {
                sum *= 0.85;
            }

            if (budget >= sum)
            {
                double leftMoney = budget - sum;
                Console.WriteLine("You have {0:f2} leva left!", leftMoney);
            }
            else
            {
                double neededMoney = sum - budget;
                Console.WriteLine("Not enough money! You need {0:f2} leva more!", neededMoney);
            }
        }
    }
}
