using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());

            int nextNumber = int.Parse(Console.ReadLine());

            int sum = nextNumber;

            while (true)
            {
                if (sum>=number)
                {
                    break;
                }

                nextNumber = int.Parse(Console.ReadLine());
                sum+=nextNumber;


            }
            Console.WriteLine(sum);
        }
    }
}
