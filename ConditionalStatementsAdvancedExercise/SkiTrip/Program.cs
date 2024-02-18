using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days=int.Parse(Console.ReadLine());
            string roomType=Console.ReadLine();
            string feedback=Console.ReadLine();
            int nights = days - 1;
            double pricePerNight = 0;
            
            switch(roomType)
            {
                case "room for one person":
                    pricePerNight = 18;
                    break;
                case "apartment":
                    pricePerNight = 25;
                    break;
                case "president apartment":
                    pricePerNight = 35;
                    break;

            }
            double totalPrice = nights * pricePerNight;

            if(roomType=="apartment")
            {
                if (days<10)
                {
                    totalPrice = totalPrice - 0.30 * totalPrice;
                }
                else if (days>=10 && days<=15)
                {
                    totalPrice = totalPrice - 0.35 * totalPrice;
                }
                else if (days>15)
                {
                    totalPrice = totalPrice - 0.50 * totalPrice;
                }
            }
            else if (roomType=="president apartment")
            {
                if (days < 10)
                {
                    totalPrice = totalPrice - 0130 * totalPrice;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalPrice = totalPrice - 0.15 * totalPrice;
                }
                else if (days > 15)
                {
                    totalPrice = totalPrice - 0.20 * totalPrice;
                }

            }
            if(feedback=="positive")
            {
                totalPrice = totalPrice + 0.25 * totalPrice;
            }
            else if (feedback=="negative")
            {
                totalPrice = totalPrice - 0.10 * totalPrice;
            }
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
