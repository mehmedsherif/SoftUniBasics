using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string seasson=Console.ReadLine();
            string destination = "";
            string type = "";
            double spendMoney = 0;

            if(budget<=100)
            {
                destination = "Bulgaria";
                if(seasson=="summer")
                {
                    spendMoney=0.30*budget;
                    type = "Camp";
                }
                else if (seasson == "winter")
                {
                    spendMoney = 0.70*budget;
                    type = "Hotel";
                }


            }
            else if(budget<=1000)
            {
                destination = "Balkans";
                if (seasson=="summer")
                {
                    spendMoney = 0.40*budget;
                    type = "Camp";
                }
                else if (seasson=="winter")
                {
                    spendMoney = 0.80 * budget;
                    type = "Hotel";
                }
            }
            else if(budget>1000)

            {
                destination = "Europe";
                spendMoney = 0.90 * budget;
                type = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {spendMoney:F2}");

        }
    }
}
