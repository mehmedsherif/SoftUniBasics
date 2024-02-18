using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month=Console.ReadLine();
            int nights=int.Parse(Console.ReadLine());

            double pricePerNightStudio =0;
            double pricePerNightApartment = 0;

            if (month=="May" || month=="October")
            {
                pricePerNightStudio = 50;
                pricePerNightApartment = 65;
            }
            else if (month=="June" || month=="September")
            {
                pricePerNightStudio = 75.20;
                pricePerNightApartment = 68.70;
            }
            else if (month=="July" || month=="August")
            {
                pricePerNightStudio = 76;
                pricePerNightApartment = 77;
            }
            double totalPriceStudio=nights*pricePerNightStudio;
            double totalPriceApartment=nights*pricePerNightApartment;
            
             if (nights>14 && (month == "May" || month == "October"))
            {
                totalPriceStudio = totalPriceStudio - 0.30 * totalPriceStudio;
            }
            else if (nights > 7 && (month == "May" || month == "October"))

            {
                totalPriceStudio = totalPriceStudio - 0.05 * totalPriceStudio;

            }
            else if (nights > 14 && (month == "June" || month == "September"))
            {
                totalPriceStudio = totalPriceStudio - 0.20 * totalPriceStudio;
            }
             if (nights>14)
            {
                totalPriceApartment = totalPriceApartment - 0.10 * totalPriceApartment;
            }
            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");

        }
    }
}
