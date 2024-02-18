using System;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens=int.Parse(Console.ReadLine());
            int markers=int.Parse(Console.ReadLine());
            int detergent=int.Parse(Console.ReadLine());
            double reduction=int.Parse(Console.ReadLine());

            double pensPrice =pens * 5.80;
            double markersPrice = markers * 7.20;
            double detergentPrice = detergent * 1.20;
            double reductionPercent=reduction/100;
            double sum = pensPrice + markersPrice + detergentPrice;
            
            double priceWithReduction=sum-sum*reductionPercent;
            Console.WriteLine(priceWithReduction);




            
        }
    }
}
