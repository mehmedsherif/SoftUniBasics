using System;
using System.Threading.Channels;

namespace CareOfPuppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodInKg=int.Parse(Console.ReadLine());

            int foodInGr = foodInKg * 1000;
            int allConsumedFood = 0;

            string command=Console.ReadLine();

           

            while(command!="Adopted")
            {
                int consumedFood=int.Parse(command);

                allConsumedFood += consumedFood;

                command=Console.ReadLine();
            }
            if (foodInGr>=allConsumedFood)
            {
                int leftovers = foodInGr - allConsumedFood;
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else
            {
                int moreFood = Math.Abs(allConsumedFood - foodInGr);
                Console.WriteLine($"Food is not enough. You need {moreFood} grams more. ");
            }
        }
    }
}
