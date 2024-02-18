using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonQuantity=int.Parse(Console.ReadLine());
            int paintQuantity=int.Parse(Console.ReadLine());
            int thinnerQuantity=int.Parse(Console.ReadLine());
            int workTime=int.Parse(Console.ReadLine());
           

            double nylonPrice = (nylonQuantity+2) * 1.50;
            double paintPrice = (paintQuantity*1.1) * 14.50;
            double thinnerPrice = thinnerQuantity * 5.00;

            double sum = nylonPrice + paintPrice + thinnerPrice + 0.40;
            double workingPrice = sum * 0.3 * workTime;
            double finalPrice = sum + workingPrice;
         
            Console.WriteLine(finalPrice);
        }
    }
}
