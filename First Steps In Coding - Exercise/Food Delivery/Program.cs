using System;

namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenQuantity=int.Parse(Console.ReadLine());
            int fishQuantity=int.Parse(Console.ReadLine());
            int veganQuantity=int.Parse(Console.ReadLine());

            double chickenPrice = chickenQuantity * 10.35;
            double fishPrice = fishQuantity * 12.40;
            double veganPrice = veganQuantity * 8.15;

            double menuPrice = chickenPrice + fishPrice + veganPrice;

            double dessertPrice = menuPrice * 0.20;

            double totalPrice = menuPrice + dessertPrice + 2.50;

                Console.WriteLine(totalPrice);
        }
    }
}
