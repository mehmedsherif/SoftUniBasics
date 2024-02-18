using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney=double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            int daysCount = 0;
            int spendCount = 0;

            while (availableMoney<neededMoney) 
            {
                string input= Console.ReadLine();
                double money=double.Parse(Console.ReadLine());
                daysCount++;
                if(input=="spend")
                {
                    spendCount++;
                    if(spendCount==5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }

                    availableMoney-=money;

                    if(availableMoney<0)
                    {
                        availableMoney = 0;
                    }
                }
                else
                {
                    availableMoney += money;
                    spendCount = 0;
                }
            }
            if(availableMoney>=neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }


        }
    }
}
