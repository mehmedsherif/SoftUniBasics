using System;

namespace MiningRig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int VideoCardPrice = int.Parse(Console.ReadLine());
            int transitionPrice = int.Parse(Console.ReadLine());
            double priceOfElectricityForDay = double.Parse(Console.ReadLine());
            double profitForDay = double.Parse(Console.ReadLine());

            int totalPriceCard = VideoCardPrice * 13;
            int totalPriceTransition = transitionPrice * 13;
            int totalSpendMoney = totalPriceCard + totalPriceTransition+1000;
            double profitCard = profitForDay - priceOfElectricityForDay;
            double totalProfitCards = 13 * profitCard;

            Console.WriteLine(totalSpendMoney);
            Console.WriteLine(Math.Ceiling(totalSpendMoney / totalProfitCards));
        }
    }
}
