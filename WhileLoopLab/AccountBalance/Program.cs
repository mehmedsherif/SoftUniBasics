using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string input=Console.ReadLine();
            while (input != "NoMoreMoney")
            {
                double newBalance = double.Parse(input);

                if(newBalance <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {newBalance:F2}");
                sum += newBalance;

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");

        }
    }
}
