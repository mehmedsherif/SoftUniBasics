using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string flowerType=Console.ReadLine(); 
            int count=int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());
            double priceFlower = 0;

            switch(flowerType)
            {
                case "Roses":
                    priceFlower = 5;
                    break;
                case "Dahlias":
                    priceFlower = 3.80;
                    break;
                case "Tulips":
                    priceFlower = 2.80;
                    break;
                case "Narcissus":
                    priceFlower = 3;
                    break;
                case "Gladiolus":
                    priceFlower = 2.50;
                    break;
            }
            double totalPrice = count * priceFlower;

            if (count>80 && flowerType=="Roses")
            {
                totalPrice = totalPrice - 0.1 * totalPrice;
            }
            else if (count>90 && flowerType=="Dahlias")
            {
                totalPrice = totalPrice - 0.15 * totalPrice;
            }
            else if (count>80 && flowerType=="Tulips")
            {
                totalPrice=totalPrice-0.15*totalPrice;
            }
            else if (count<120 && flowerType=="Narcissus")
            {
                totalPrice = totalPrice + 0.15 * totalPrice;
            }
            else if (count<80 && flowerType=="Gladiolus")
            {
                totalPrice = totalPrice + 0.20 * totalPrice;
            }
            if (budget>=totalPrice)
            {
                double leftSum = budget - totalPrice;
                Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {leftSum:F2} leva left.");
            }
            else
            {
                double needSum = totalPrice - budget;
                Console.WriteLine($"Not enough money, you need {needSum:F2} leva more.");
            }

        }
    }
}
