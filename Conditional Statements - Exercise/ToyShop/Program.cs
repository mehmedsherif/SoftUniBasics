using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int tedyBear = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int tracks = int.Parse(Console.ReadLine());

            double purchases = puzle * 2.60 + doll * 3.00 + tedyBear * 4.10 + minions * 8.20 + tracks * 2.00;

            if (puzle + doll + tedyBear + minions + tracks >= 50)
            {
                purchases -= purchases * 0.25;
            }
            if (purchases * (1 - 0.1) >= vacationPrice)
            {
                Console.WriteLine($"Yes! {(purchases * (1 - 0.1)) - vacationPrice:f2} lv left.");
            }
            else if (purchases * (1 - 0.1) < vacationPrice)
            {
                Console.WriteLine($"Not enough money! {vacationPrice - (purchases * (1 - 0.1)):f2} lv needed.");
            }
        }
    }
}
