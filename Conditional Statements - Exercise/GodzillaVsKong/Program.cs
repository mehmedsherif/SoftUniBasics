using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget=double.Parse(Console.ReadLine());
            int extras=int.Parse(Console.ReadLine());
            double clothingPrice=double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double priceForExtras=extras*clothingPrice;

            if(extras>150)
            {
                priceForExtras = priceForExtras - priceForExtras * 0.10;
            }
            double totalPrice = priceForExtras + decor;
            if(budget>=totalPrice)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget-totalPrice):F2} leva more.");
            }
        }
    }
}
